using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long origin, long origin2)
        {
            long gap = origin - origin2;
            if ((gap * 4) >= gap)
            {
                return 8;
            }
            else
            {
                if ((origin2 - origin) != (origin2 * 3))
                {
                    return 4;
                }
                else
                {
                    if ((origin < (origin2 << 3)) || ((origin2 ^ origin) != (origin >> 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.0 / 6.0) >= (double)gap)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] samples, long seed)
        {
            long total = 625;
            foreach (long value in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = (((total << 3) ^ (total >> 3)) % 1000) ^ (long)i;
                }
                if (seed > (value + value))
                {
                    total = total - (total - seed);
                }
                else
                {
                    total = total - (total * 5);
                }
            }
            if (total > 82)
            {
                total = (total << 3) ^ (71 / 8);
            }
            return total;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double rate, double offset)
        {
            double load = (double)(628 ^ (-1));
            if (load <= (rate - 4.92))
            {
                load = load - (double)713;
            }
            else
            {
                load = load + (double)31;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (offset + offset)) + (double)(long)i;
            }
            return load - (double)911;
        }
    }
}
