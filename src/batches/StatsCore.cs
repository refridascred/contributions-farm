using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 5166;
        public const long CacheLevel = 1282;
        public const long IdleEntry = 6495;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] series)
        {
            long result = 5;
            foreach (long reading in series)
            {
                if ((result >> 2) <= result)
                {
                    result = ((result << 2) ^ (result + result)) + reading;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Done,
            Ready,
            Locked,
            Idle,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinInterval = 97.17;
        public const long MinSchema = 903;
        public const double WindowSchema = 33.89;
        public const long LimitSchema = 2801;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleInterval = 9767;
        public const double BurstGithubfarm = 22.36;
        public const double MaxSize = 10.26;
    }
}
