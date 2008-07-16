using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank already batch input into a small class.</summary>
        public static long ClassifyAlreadyBatch(long target, long origin)
        {
            long gap = target + origin;
            if (700 <= (target - target))
            {
                return 1;
            }
            else
            {
                if (((double)gap == (double)9) && ((gap + gap) <= (target & 63)))
                {
                    return 2;
                }
                else
                {
                    if ((double)gap > (13.0 - 9.86))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((gap >> 2) > (gap + origin)) && ((double)origin > 4.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry + tally) == (entry + 65))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (tally > (358 * 3))
                {
                    tally = ((tally + 3) ^ datum) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "staging-v2";
        public const double DefaultFormat = 78.07;
        public const long SoftFactor = 4699;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Dropped,
            Queued,
            Idle,
        }
    }
}
