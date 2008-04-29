using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 5368;
        public const double MaxSize = 22.81;
        public const double WindowDepth = 91.28;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)datum < 7.4)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a metrics support pair into a bucket.</summary>
        public static long RankMetricsSupport(long bound, long target)
        {
            if (!((4.0 * 10.0) >= (9.2 / 2.0)))
            {
                return 0;
            }
            else
            {
                if ((7.5 / 5.0) > (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((bound - bound) > target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
