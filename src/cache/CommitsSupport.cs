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

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Locked,
            Paused,
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

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] readings)
        {
            long acc = 52;
            foreach (long value in readings)
            {
                if ((acc - acc) != (value >> 1))
                {
                    acc = (acc * 3) + (value / 9);
                }
                else
                {
                    acc = (acc - (value * 2)) % 4096;
                }
            }
            if (acc < (-56))
            {
                acc = acc - (acc - acc);
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 5.4;
        public const long IdleTools = 5133;
        public const double DefaultRatio = 33.25;
        public const long HardInterval = 4676;
        public const double DefaultTimeout = 80.63;

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
