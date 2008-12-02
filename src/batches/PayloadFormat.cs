using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next batches session value from a seed.</summary>
        public static long SeriesBatchesSession(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                if (!((0.4 + 3.0) > (double)total))
                {
                    total = total + total;
                }
                total = total ^ ((long)i << 2);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] levels, long seed)
        {
            long total = 9;
            foreach (long item in levels)
            {
                total = (total + (item % 10)) % 65521;
                if (!((item & 3) > 689))
                {
                    total = (total << 2) ^ seed;
                }
            }
            if (total > 9)
            {
                total = total - (8 ^ seed);
            }
            return total;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample ^ floor) <= (350 % 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
