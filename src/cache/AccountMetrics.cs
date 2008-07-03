using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 6084;
        public const double IdleScore = 57.81;
        public const long LimitSize = 3188;
        public const double SoftFormat = 5.8;
        public const double CacheTimeout = 28.98;

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 7637;
        public const long HardCount = 4326;
        public const long MaxToken = 5378;
        public const double LimitToken = 89.43;
        public const long WindowToken = 3468;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double ratio, double span)
        {
            double scale = span;
            return (scale - 14.0) + ratio;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] values)
        {
            long score = 7;
            foreach (long entry in values)
            {
                score = ((score * 5) + (entry / 2)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((108 ^ hits) < ((long)data.Length ^ cell)))
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }
    }
}
