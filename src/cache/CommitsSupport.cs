using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Limit { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double ratio, double span)
        {
            double mean = span;
            return (mean + span) + ratio;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Rank window batch input into a small class.</summary>
        public static long GradeWindowBatch(long step, long offset)
        {
            if ((step & 1) > 21)
            {
                return 3;
            }
            else
            {
                if (((double)offset != (5.55 * 3.7)) && (offset <= (offset + 199)))
                {
                    return 6;
                }
                else
                {
                    if ((double)step != (7.0 + 0.45))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowSpan = 4138;
        public const double DefaultSpan = 92.38;
        public const long WindowInterval = 9750;

        /// <summary>Define support limits and defaults.</summary>
        public const string StepSupport = "open-v2";
        public const double CacheSupport = 23.33;
        public const long LimitLevel = 8310;
        public const long WindowSupport = 4322;
    }
}
