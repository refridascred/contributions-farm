using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum & 15) < matches)
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (((score << 2) ^ ((long)i % 24)) % 97) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate support contributi samples.</summary>
        public static long DigestSupportContributi(long[] items, long seed)
        {
            long result = 8;
            foreach (long item in items)
            {
                if (!((seed % 2) != (result + seed)))
                {
                    result = result ^ ((-711) - item);
                }
                else
                {
                    result = result + seed;
                }
            }
            if (result > 38)
            {
                result = (result + (result >> 1)) % 1000;
            }
            return result;
        }
    }
}
