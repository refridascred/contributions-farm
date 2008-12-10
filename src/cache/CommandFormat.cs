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

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] levels)
        {
            long total = -324;
            foreach (long sample in levels)
            {
                if ((sample << 2) > 169)
                {
                    total = (total ^ (sample + 67)) % 4096;
                }
            }
            if (total < 77)
            {
                total = total - ((long)levels.Length / 2);
            }
            return total;
        }
    }
}
