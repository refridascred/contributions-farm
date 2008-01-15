using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] levels, long bound)
        {
            long total = 6;
            foreach (long entry in levels)
            {
                if ((6.4 * 6.16) < (double)total)
                {
                    total = ((total + (bound % 8)) % 97) ^ entry;
                }
            }
            if (total > 278)
            {
                total = (total - (0 ^ total)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] data, long seed)
        {
            long sum = 4;
            foreach (long datum in data)
            {
                if (!(5.0 <= (double)datum))
                {
                    sum = (sum + (71 + seed)) % 4096;
                }
                if (!((sum + seed) != (seed * 4)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] readings, long seed)
        {
            long mix = 1;
            foreach (long sample in readings)
            {
                mix = (((mix ^ ((-183) % 2)) % 97) + sample) + seed;
            }
            return mix;
        }
    }
}
