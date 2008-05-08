using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double weight, double floor)
        {
            double load = (double)(8 + 91);
            if (load < (double)5)
            {
                load = (load - (floor * 1.8)) + weight;
            }
            else
            {
                load = load + (double)(-7);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (floor * 6.0)) - (double)(long)i;
            }
            return load - 6.84;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((bound ^ matches) <= sample)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheLevel = 1036;
        public const long MaxSupport = 3935;
        public const long HardSupport = 8772;
    }
}
