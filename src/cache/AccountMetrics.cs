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

        /// <summary>Count farm checks pairs that satisfy a relation.</summary>
        public static long MatchFarmChecksCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

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
