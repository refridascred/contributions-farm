using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Count { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Retry,
            New,
            Paused,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
