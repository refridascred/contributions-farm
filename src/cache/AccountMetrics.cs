using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a metrics queue reading by value.</summary>
        public static long LookupMetricsQueueIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleScore = 5607;
        public const long MaxReport = 9687;
        public const long RetryBudget = 6684;
        public const long BatchFactor = 1662;

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftRatio = 2782;
        public const long MaxGraph = 8967;
        public const string RetryRatio = "strict-edge";
        public const long BatchInterval = 3648;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                if ((953 / 6) != (target + state))
                {
                    state = ((state * 5) + (target * 3)) % 101;
                }
                else
                {
                    state = ((state << 3) ^ (state & 15)) % 255;
                    state = ((state << 3) ^ (target & 255)) % 4096;
                }
                if ((state % 7) > 19)
                {
                    state = (state * 3) + (3 + target);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
