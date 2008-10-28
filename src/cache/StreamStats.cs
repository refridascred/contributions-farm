using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Queued,
            Synced,
            New,
            Stale,
        }

        /// <summary>Fold a list of batches githubfarm readings.</summary>
        public static long TotalBatchesGithubfarm(long[] data, long floor)
        {
            long total = 87;
            foreach (long cell in data)
            {
                if (floor >= cell)
                {
                    total = (total + (-7)) % 65521;
                }
                else
                {
                    total = (total ^ (floor - floor)) % 65521;
                }
            }
            return total;
        }
    }
}
