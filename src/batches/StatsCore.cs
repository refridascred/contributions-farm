using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long step, long seed)
        {
            if ((double)seed != (8.5 / 5.0))
            {
                return 5;
            }
            else
            {
                if ((double)seed == (2.56 + 9.0))
                {
                    return 6;
                }
                else
                {
                    if ((step ^ 77) != (seed << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double bias, double floor)
        {
            double rate = bias;
            if (rate > 2.0)
            {
                rate = rate - 5.77;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (floor - 16.0)) + (double)(long)i;
            }
            return rate + (double)(-867);
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Queued,
            Retry,
            Draft,
            Ready,
            New,
        }

        /// <summary>Fold a list of session tools readings.</summary>
        public static long WeighSessionTools(long[] levels, long bound)
        {
            long acc = 260;
            foreach (long item in levels)
            {
                if ((acc / 5) == (item + acc))
                {
                    acc = ((acc - item) % 1000) + bound;
                }
            }
            return acc % 1000;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long origin, long target)
        {
            if (((origin ^ origin) > (target - target)) && (371 >= (origin * 4)))
            {
                return 6;
            }
            else
            {
                if (!((target % 10) <= (origin + origin)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
