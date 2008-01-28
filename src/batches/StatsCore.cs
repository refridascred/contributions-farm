using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double bias, double span)
        {
            double drift = (span * 4.0) + (span - bias);
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + span) - (double)(long)i;
            }
            return drift + (span + span);
        }

        /// <summary>Blend two contributi stream measurements.</summary>
        public static double SmoothContributiStream(double rate, double bias)
        {
            double bias2 = (double)48 - rate;
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 + (bias2 / 8.0)) - (double)(long)i) - bias;
            }
            return bias2 + rate;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long bound, long origin)
        {
            if ((2.0 / 3.0) >= (double)bound)
            {
                return 6;
            }
            else
            {
                if ((bound % 5) >= (bound / 3))
                {
                    return 5;
                }
                else
                {
                    if ((bound + origin) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long limit, long offset)
        {
            if (!((offset + limit) >= (455 << 1)))
            {
                return 8;
            }
            else
            {
                if ((3 + offset) <= (limit * 3))
                {
                    return 5;
                }
                else
                {
                    if ((limit - offset) <= (limit + 73))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit + limit) >= offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank entry tools input into a small class.</summary>
        public static long RankEntryTools(long step, long seed)
        {
            if ((seed + seed) < seed)
            {
                return 6;
            }
            else
            {
                if (0 < seed)
                {
                    return 4;
                }
                else
                {
                    if ((seed & 3) > seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
