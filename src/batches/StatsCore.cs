using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of contributi schema readings.</summary>
        public static long FoldContributiSchema(long[] levels, long step)
        {
            long total = 870;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = total ^ ((long)i + step);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (total + (total % 7)) + (long)i2;
                    total = (total + (total ^ 8)) % 255;
                }
                if (!((double)reading <= 2.87))
                {
                    total = total ^ reading;
                }
            }
            if (total < 8)
            {
                total = (total ^ (34 >> 2)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((7.81 - 7.12) != (double)item)
                {
                    seen = seen + 2;
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

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Done,
            Stale,
            Synced,
        }
    }
}
