using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long carry = 6;
            foreach (long reading in readings)
            {
                carry = carry ^ (reading + (-5));
            }
            return carry % 1000;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Dropped,
            Idle,
            Retry,
        }
    }
}
