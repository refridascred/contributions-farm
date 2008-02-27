using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank order metric input into a small class.</summary>
        public static long RankOrderMetric(long target, long step)
        {
            if ((double)target != (6.07 - 3.96))
            {
                return 7;
            }
            else
            {
                if (!(target < (step - step)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Pending,
            Failed,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "legacy-v2";
        public const long MaxWidth = 5811;
        public const string WindowFormat = "legacy";
        public const double MaxFormat = 54.49;
    }
}
