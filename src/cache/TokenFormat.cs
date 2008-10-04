using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Closed,
            Dropped,
            New,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
