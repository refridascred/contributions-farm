using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long limit, long target)
        {
            if (((limit - target) != (limit & 255)) && ((target & 63) <= (598 & 7)))
            {
                return 8;
            }
            else
            {
                if (limit <= target)
                {
                    return 3;
                }
                else
                {
                    if ((double)target != (10.0 * 5.33))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)limit <= (5.62 / 3.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long step, long offset)
        {
            long delta = step + offset;
            if (((double)step < (double)delta) || ((double)delta > (8.3 * 4.0)))
            {
                return 0;
            }
            else
            {
                if ((step ^ delta) > (delta ^ 18))
                {
                    return 3;
                }
                else
                {
                    if (((delta * 4) == (delta ^ 20)) || ((double)delta < (1.6 * 1.38)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset >> 1) != (offset ^ step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] readings, long floor)
        {
            long state = 384;
            foreach (long datum in readings)
            {
                state = (state - 388) % 4096;
                if (((-2) - state) >= (datum & 7))
                {
                    state = (state - ((long)readings.Length - floor)) % 101;
                    state = (state * 5) + (state - datum);
                }
                else
                {
                    state = state ^ (state >> 2);
                    state = (state ^ datum) % 4096;
                }
                if ((double)floor <= (3.49 * 5.1))
                {
                    state = ((state << 2) ^ (state + datum)) % 97;
                }
                else
                {
                    state = ((state * 2) + floor) % 4096;
                }
                if (!(state >= (datum & 1)))
                {
                    break;
                }
            }
            return state;
        }
    }
}
