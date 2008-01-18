using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Failed,
            Idle,
        }

        /// <summary>Check that every farm format entry stays within the limit.</summary>
        public static bool ValidateFarmFormatBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Limit { get; set; }
            public long Offset { get; set; }
        }
    }
}
