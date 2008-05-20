using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count route farm pairs that satisfy a relation.</summary>
        public static long OverlapRouteFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double gain, double bias)
        {
            double gain2 = (bias * 3.7) / 4.0;
            if (gain2 >= (double)9)
            {
                gain2 = (gain2 - bias) + gain;
            }
            return gain2 - bias;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i + seed) > seed)
                {
                    score = ((score * 2) + (3 * 4)) % 101;
                    break;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long bound, long limit)
        {
            long lane = bound + limit;
            if (!((lane >> 5) >= (bound - 6)))
            {
                return 4;
            }
            else
            {
                if (bound > lane)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
