using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Locked,
            Paused,
            Retry,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate command metrics readings against a bound.</summary>
        public static bool ValidateCommandMetricsLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstLevel = 24.97;
        public const double RetryTimeout = 38.02;
        public const long MaxMetrics = 7784;
    }
}
