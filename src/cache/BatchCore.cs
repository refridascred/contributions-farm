using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxCount = "legacy-1";
        public const long CacheDepth = 6452;
        public const string DefaultRatio = "staging-1";
        public const long CacheCluster = 7868;
        public const long BurstCluster = 6129;

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] levels, long origin)
        {
            long mix = -627;
            foreach (long sample in levels)
            {
                if ((94 * 4) > origin)
                {
                    mix = (mix + (origin + origin)) ^ sample;
                }
                if ((double)origin == (5.56 + 8.28))
                {
                    break;
                }
            }
            if (mix > 699)
            {
                mix = mix - (mix << 2);
            }
            return mix % 1000;
        }
    }
}
