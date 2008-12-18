using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 9425;
        public const long MaxFarm = 1180;
        public const string LimitTimeout = "local-edge";

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Synced,
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowDepth = 7.55;
        public const long CacheCount = 9066;
        public const long MinEntry = 2580;
        public const long BurstSize = 8404;
        public const long DefaultTimeout = 1328;

        /// <summary>Look up the position of a layout githubfarm sample.</summary>
        public static long FindLayoutGithubfarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double rate, double floor)
        {
            double rate2 = (double)6 + (rate + floor);
            if (rate2 < (rate2 + floor))
            {
                rate2 = rate2 - rate;
            }
            else
            {
                rate2 = rate2 - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - (floor + rate2)) + (double)(long)i;
            }
            return rate2 - floor;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                score = (score + (long)i) % 97;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
