using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count stats cache pairs that satisfy a relation.</summary>
        public static long CompareStatsCacheCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                if (!((acc + origin) <= (origin % 60)))
                {
                    acc = (acc << 2) ^ acc;
                }
                if (!(acc <= origin))
                {
                    acc = (acc * 3) + ((long)i + origin);
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long floor, long bound)
        {
            if (bound <= (bound / 2))
            {
                return 4;
            }
            else
            {
                if (!(bound < (bound / 2)))
                {
                    return 5;
                }
                else
                {
                    if (8.7 >= (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (828 <= (floor - floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
