using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate githubfarm checks readings against a bound.</summary>
        public static bool ValidateGithubfarmChecksLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of tools session readings.</summary>
        public static long MatchToolsSessionCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Closed,
            Locked,
            Pending,
            Draft,
            Synced,
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
        }
    }
}
