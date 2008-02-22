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

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "legacy-1";
        public const string HardRatio = "legacy-v2";
        public const double BaseDepth = 57.94;

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
