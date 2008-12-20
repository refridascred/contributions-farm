using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next tools payload value.</summary>
        public static double ProjectToolsPayload(double scale, double bias)
        {
            double weight = 20.0;
            return (weight - bias) + scale;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Synced,
            Retry,
            Dropped,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Region { get; set; }
            public string Token { get; set; } = "";
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Mode { get; set; }
            public double Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Check that every githubfarm profile entry stays within the limit.</summary>
        public static bool ValidateGithubfarmProfileLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
