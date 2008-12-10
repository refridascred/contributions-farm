using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a account commits value against two limits.</summary>
        public static long RankAccountCommits(long limit, long floor)
        {
            long step = limit - floor;
            if ((8.8 - 2.1) <= (double)step)
            {
                return 3;
            }
            else
            {
                if ((floor - limit) > (floor & 255))
                {
                    return 0;
                }
                else
                {
                    if ((limit / 5) >= step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate cache command samples.</summary>
        public static long TallyCacheCommand(long[] series, long target)
        {
            long total = 0;
            foreach (long value in series)
            {
                if (!((4.6 - 5.76) < (double)target))
                {
                    total = (total * 3) + (total + (long)series.Length);
                    total = (total * 2) + (value + value);
                }
                if ((total / 9) <= 2)
                {
                    total = (total << 3) ^ (value * 4);
                }
                else
                {
                    total = ((total << 2) ^ (target / 6)) % 1000;
                }
            }
            if (total > 13)
            {
                total = (total << 3) ^ (total >> 4);
            }
            return total % 4096;
        }

        /// <summary>Roll a route window counter forward.</summary>
        public static long StepRouteWindow(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                score = (score * 5) + score;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count stats channel pairs that satisfy a relation.</summary>
        public static long MatchStatsChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
