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

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
