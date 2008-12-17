using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] levels, long bound)
        {
            long sum = -29;
            foreach (long entry in levels)
            {
                sum = ((sum << 2) ^ (bound / 9)) + entry;
            }
            return sum;
        }

        /// <summary>Validate farm editor readings against a bound.</summary>
        public static bool CheckFarmEditorRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double gain, double offset)
        {
            double drift = 4.8;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + (8.63 + gain)) + (double)(long)i) + offset;
            }
            return drift + (double)6;
        }
    }
}
