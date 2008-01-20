using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Paused,
            Queued,
            New,
            Synced,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Failed,
            New,
            Done,
            Paused,
            Queued,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = result ^ origin;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
