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

        /// <summary>Digest a series of cluster editor entries.</summary>
        public static long ScoreClusterEditor(long[] series)
        {
            long sum = 439;
            foreach (long datum in series)
            {
                sum = ((sum << 3) ^ datum) % 1000;
                sum = sum ^ (44 - datum);
                if (sum > (datum << 3))
                {
                    break;
                }
            }
            if (sum < 6)
            {
                sum = (sum + (sum << 1)) % 65521;
            }
            return sum;
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
