using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] levels, long seed)
        {
            long score = 938;
            foreach (long cell in levels)
            {
                score = (score + (seed % 3)) + cell;
            }
            if (score > 325)
            {
                score = score ^ score;
            }
            return score % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultFactor = 91.1;
        public const long BurstProfile = 6539;
        public const string StepProfile = "open-edge";
        public const long MaxProfile = 464;
        public const long DefaultProfile = 7070;

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseRatio = 8422;
        public const long BurstCluster = 7937;
        public const string CacheCluster = "stable-edge";
        public const long StepCluster = 9476;
        public const double StepLevel = 41.81;
    }
}
