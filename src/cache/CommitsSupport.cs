using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels, long origin)
        {
            long total = 7;
            foreach (long sample in levels)
            {
                total = ((total + sample) % 255) + origin;
            }
            return total;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] data)
        {
            long mark = 550;
            foreach (long datum in data)
            {
                if ((mark * 2) > datum)
                {
                    mark = ((mark << 2) ^ mark) % 101;
                }
                if ((mark & 127) <= (mark ^ mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 97.23;
        public const string StepStats = "stable";
        public const long RetryLevel = 5034;
        public const long IdleStats = 6130;
        public const string CacheStats = "alpha-v2";

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Synced,
            Failed,
            Paused,
            Done,
        }
    }
}
