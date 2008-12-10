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

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Queued,
            Locked,
            Closed,
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
