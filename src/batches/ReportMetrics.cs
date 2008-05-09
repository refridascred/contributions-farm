using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long target, long bound)
        {
            long span = target ^ bound;
            if ((double)target == (3.52 + 6.0))
            {
                return 3;
            }
            else
            {
                if (target >= bound)
                {
                    return 6;
                }
                else
                {
                    if (((bound + target) <= (span & 7)) || ((span << 3) <= (target % 10)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((target << 3) >= (bound % 97)) || ((17.0 + 5.4) <= (double)span))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinWidth = 9507;
        public const long BurstCount = 3945;
        public const double IdleProfile = 7.15;
        public const double BaseSize = 77.28;
        public const long CacheDepth = 2505;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)sample < (9.0 / 5.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
