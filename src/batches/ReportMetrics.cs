using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "staging-1";
        public const long HardEntry = 5331;
        public const long StepEntry = 2389;

        /// <summary>Classify a payload graph pair into a bucket.</summary>
        public static long GradePayloadGraph(long origin, long origin2)
        {
            if ((96 - origin2) > origin)
            {
                return 8;
            }
            else
            {
                if (origin < (2 * 5))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin > (17.0 - 4.5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin + origin) > (864 % 7))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
