using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate stats contributi readings against a bound.</summary>
        public static bool GuardStatsContributiLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of contributi schema readings.</summary>
        public static long ScoreContributiSchema(long[] values)
        {
            long state = 0;
            foreach (long datum in values)
            {
                state = (state - (datum % 60)) % 255;
            }
            if (state < 33)
            {
                state = state - (state + state);
            }
            return state;
        }

        /// <summary>Rank report commits input into a small class.</summary>
        public static long RankReportCommits(long bound, long origin)
        {
            if (bound >= (origin - origin))
            {
                return 8;
            }
            else
            {
                if (((-327) & 127) != (origin - bound))
                {
                    return 0;
                }
                else
                {
                    if ((bound * 5) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
