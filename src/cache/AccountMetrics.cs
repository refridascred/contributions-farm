using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate format farm samples.</summary>
        public static long WeighFormatFarm(long[] samples)
        {
            long mix = 374;
            foreach (long item in samples)
            {
                if ((double)item >= (double)mix)
                {
                    mix = ((mix << 3) ^ item) % 4096;
                }
                if ((double)mix == (5.0 * 10.0))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string IdleLevel = "open";
        public const double LimitDepth = 48.36;
        public const string MaxToken = "cached-1";
        public const long HardToken = 4622;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Locked,
            Active,
            Paused,
            Pending,
            Queued,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardBudget = "open-edge";
        public const double DefaultChecks = 88.18;
        public const long BaseDepth = 1650;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Done,
            Failed,
        }
    }
}
