using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a command token pair into a bucket.</summary>
        public static long SortCommandToken(long floor, long target)
        {
            long next = floor ^ target;
            if (((floor - 210) < (next >> 4)) || ((next ^ target) > (floor - floor)))
            {
                return 4;
            }
            else
            {
                if (((next + floor) <= (504 - 2)) || (((-366) / 8) >= (target + 43)))
                {
                    return 6;
                }
                else
                {
                    if ((floor >> 3) < floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target + next) > (target + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank batches farm input into a small class.</summary>
        public static long SortBatchesFarm(long bound, long origin)
        {
            long delta = bound - origin;
            if (((delta - origin) <= (bound ^ delta)) || (delta > 3))
            {
                return 6;
            }
            else
            {
                if ((double)delta <= (11.0 - 7.0))
                {
                    return 5;
                }
                else
                {
                    if (!((double)bound != (double)origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin != (6.0 + 5.02))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate filter format readings against a bound.</summary>
        public static bool GuardFilterFormatBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the notes payload series from a seed.</summary>
        public static long RollNotesPayload(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                state = state - ((long)i * 5);
                state = (state ^ ((long)i + (long)i)) % 255;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Rank { get; set; }
            public double Weight { get; set; }
        }
    }
}
