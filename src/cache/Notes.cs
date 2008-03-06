using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long floor, long floor2)
        {
            if (floor2 >= (floor % 97))
            {
                return 4;
            }
            else
            {
                if ((floor2 ^ floor) > ((-23) % 16))
                {
                    return 5;
                }
                else
                {
                    if ((floor2 >> 5) > (floor2 + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (floor2 < floor)
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

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] levels)
        {
            long state = 49;
            foreach (long cell in levels)
            {
                if ((1 & 1) >= (cell + state))
                {
                    state = (state ^ (cell - state)) % 1000;
                    state = (state ^ (cell - cell)) % 255;
                }
                if ((565 * 5) < (cell % 8))
                {
                    state = (state - (767 % 2)) % 101;
                }
                if (!((23 + 8) <= (cell * 3)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor - (long)i) % 65521;
                if ((anchor + floor) != (anchor / 7))
                {
                    anchor = (anchor + ((long)i ^ floor)) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Rank { get; set; }
            public double Score { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
