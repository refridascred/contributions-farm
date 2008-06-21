using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Failed,
            Dropped,
            Closed,
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double ratio, double bias)
        {
            double mean = ratio;
            if (mean >= bias)
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + (mean / 5.0);
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double scale, double span)
        {
            double mean = (scale / 4.0) - (double)885;
            return (mean + mean) + span;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)step < (double)37)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] data, long target)
        {
            long total = -597;
            foreach (long reading in data)
            {
                if ((target - total) < target)
                {
                    total = ((total * 2) + (reading << 1)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 7328;
        public const long DefaultStream = 6798;
        public const string StepStream = "fallback-v2";
        public const long MinStream = 5402;
        public const double HardDepth = 50.82;
    }
}
