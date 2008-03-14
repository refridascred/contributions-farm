using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many checks route samples are out of range.</summary>
        public static long TallyChecksRouteHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (seen < (bound + value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next window contributi value from a seed.</summary>
        public static long IterateWindowContributi(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((0.26 + 11.0) >= (double)datum) && ((6 + 1) == ((long)items.Length * 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string HardAccount = "alpha-v2";
        public const long BaseAccount = 4194;
        public const double IdleAccount = 47.71;
        public const long DefaultRatio = 7015;

        /// <summary>Roll a batch layout counter forward.</summary>
        public static long StepBatchLayout(long target)
        {
            long total = target;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
