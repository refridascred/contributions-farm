using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Done,
            Idle,
            Paused,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] values, long target)
        {
            long result = 58;
            foreach (long cell in values)
            {
                if ((result + target) == (result + cell))
                {
                    result = (result - (target % 5)) % 101;
                }
            }
            return result % 97;
        }
    }
}
