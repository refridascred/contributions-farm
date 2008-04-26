using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Count { get; set; } = "";
            public bool Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Roll a tools channel counter forward.</summary>
        public static long RollToolsChannel(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
