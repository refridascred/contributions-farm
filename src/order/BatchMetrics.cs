using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Token { get; set; }
            public double Owner { get; set; }
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double HardSize = 20.66;
        public const long BurstWidth = 2281;
        public const string WindowFormat = "strict-1";

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long target, long bound)
        {
            long diff = target + bound;
            if (((bound % 12) > bound) && ((0 % 5) >= bound))
            {
                return 7;
            }
            else
            {
                if (((target * 2) == (target % 10)) || (225 > (diff - target)))
                {
                    return 4;
                }
                else
                {
                    if (((bound - diff) >= (target - bound)) || ((target + 2) >= bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySpan = 23.45;
        public const double LimitTimeout = 66.56;
        public const string DefaultSupport = "staging";

        /// <summary>Classify a format batches pair into a bucket.</summary>
        public static long RankFormatBatches(long step, long offset)
        {
            long next = step + offset;
            if (((next - offset) != (next % 2)) && ((next ^ offset) != (step - 801)))
            {
                return 0;
            }
            else
            {
                if (((1.6 - 4.39) > (double)next) || ((9.67 - 3.8) != (double)next))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
