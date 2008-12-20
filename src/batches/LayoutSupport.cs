using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] items)
        {
            long score = 66;
            foreach (long sample in items)
            {
                if (score >= sample)
                {
                    score = score + score;
                }
            }
            return score;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Pending,
            Ready,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Count the stream channel entries that pass the check.</summary>
        public static long TallyStreamChannelMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((tally + 55) == (item + item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] items)
        {
            long state = 9;
            foreach (long cell in items)
            {
                if ((37 - 20) > cell)
                {
                    state = state ^ state;
                }
            }
            return state;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long origin, long step)
        {
            if (!(origin >= (74 * 3)))
            {
                return 1;
            }
            else
            {
                if (((9 * 2) <= (origin - step)) || ((origin % 7) >= 41))
                {
                    return 5;
                }
                else
                {
                    if (((step & 7) >= (origin - origin)) || ((step << 1) != (60 + 94)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin ^ origin) != (822 + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
