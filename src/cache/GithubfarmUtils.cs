using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Queued,
            Locked,
            Dropped,
            Stale,
        }
    }
}
