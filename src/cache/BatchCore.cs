using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the record profile series from a seed.</summary>
        public static long IterateRecordProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((seed % 5) >= ((long)i + sum)) || ((double)7 >= (double)sum))
                {
                    sum = ((sum << 2) ^ ((long)i * 2)) % 1000;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = ((sum ^ (seed + sum)) % 255) + (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftRatio = 57.63;
        public const double StepCache = 43.12;
        public const double MaxCache = 58.64;
        public const long CacheCount = 5805;
        public const double StepWidth = 73.02;

        /// <summary>Audit support command readings against a rule.</summary>
        public static long CountSupportCommandOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry - seen) != (600 >> 4))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }
    }
}
