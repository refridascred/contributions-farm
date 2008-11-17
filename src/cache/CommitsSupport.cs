using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardWidth = 6925;
        public const long CacheAccount = 7955;
        public const long BurstAccount = 521;

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every context stats entry stays within the limit.</summary>
        public static bool ValidateContextStatsLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Retry,
            Pending,
            Active,
        }

        /// <summary>Adjust a farm editor reading.</summary>
        public static double SmoothFarmEditor(double rate, double span)
        {
            double rate2 = span;
            if (rate2 <= (double)46)
            {
                rate2 = (rate2 - rate2) + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - rate2) + (double)(long)i;
            }
            return rate2 - (span * 4.3);
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
