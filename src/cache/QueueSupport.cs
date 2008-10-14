using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double scale, double offset)
        {
            double mean = (double)(6 / 9);
            if (mean >= (double)9)
            {
                mean = ((mean - (mean / 3.0)) + scale) - offset;
            }
            else
            {
                mean = mean + 11.0;
            }
            return mean + mean;
        }

        /// <summary>Find the first session metrics entry that matches the target.</summary>
        public static long FindSessionMetricsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
