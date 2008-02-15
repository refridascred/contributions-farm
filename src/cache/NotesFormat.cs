using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long target)
        {
            long state = target;
            for (int i = 0; i < 22; i++)
            {
                state = state ^ (long)i;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long seed, long floor)
        {
            if ((8.0 / 4.0) < (double)floor)
            {
                return 5;
            }
            else
            {
                if ((double)floor < (5.2 + 8.7))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor > (9.6 / 3.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2.3 - 3.8) >= (double)floor)
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
