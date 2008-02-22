using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstScore = 1249;
        public const long SoftFarm = 5361;
        public const long IdleFarm = 3033;
        public const long LimitFarm = 3078;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Failed,
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Synced,
            New,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
