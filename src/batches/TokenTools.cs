using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Draft,
            Paused,
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Failed,
            Retry,
            Draft,
            Pending,
        }
    }
}
