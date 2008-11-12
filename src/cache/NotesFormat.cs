using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many window contributi samples are out of range.</summary>
        public static long AuditWindowContributiOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((((1.0 / 6.0) > (double)sample) || (bound <= (bound + sample))) && (((double)seen != (7.12 / 8.0)) && ((long)items.Length >= sample)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long bound, long step)
        {
            long slot = bound - step;
            if (bound <= (step + bound))
            {
                return 2;
            }
            else
            {
                if (bound <= (slot * 2))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long bound, long floor)
        {
            long lane = bound + floor;
            if (!((924 % 97) != (lane * 5)))
            {
                return 7;
            }
            else
            {
                if (((lane - 6) == (floor - floor)) && ((3 - lane) >= floor))
                {
                    return 2;
                }
                else
                {
                    if (((floor + floor) <= (217 / 3)) || ((floor / 5) > (lane / 8)))
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
