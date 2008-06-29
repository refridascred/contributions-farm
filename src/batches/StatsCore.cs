using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Paused,
            Done,
            Synced,
            Ready,
        }

        /// <summary>Compare every pair of githubfarm cache readings.</summary>
        public static long MatchGithubfarmCacheCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long limit, long offset)
        {
            if (((double)limit > 8.0) && ((limit + offset) > limit))
            {
                return 3;
            }
            else
            {
                if ((offset & 15) != (limit ^ limit))
                {
                    return 8;
                }
                else
                {
                    if ((double)offset < (9.9 - 19.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((offset & 63) != (limit * 3)) && (limit <= (offset + limit)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 217;
        public const long RetryLayout = 5428;
        public const double IdleLayout = 52.93;
        public const long MinLayout = 7192;
        public const double LimitLayout = 86.9;

        /// <summary>Count the support cluster entries that pass the check.</summary>
        public static long MeasureSupportClusterGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)717 <= (double)seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }
    }
}
