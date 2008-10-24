using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long limit, long target)
        {
            long offset = limit ^ target;
            if ((double)limit >= (1.24 + 3.14))
            {
                return 2;
            }
            else
            {
                if ((offset <= (target + offset)) || ((double)target != (double)0))
                {
                    return 0;
                }
                else
                {
                    if ((target + 670) > (offset * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((2 + 131) < (target + limit)) || ((double)limit < (1.02 * 0.29)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many window channel samples are out of range.</summary>
        public static long CountWindowChannelOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count - 820) >= (item & 31))
                {
                    count = count + 3;
                }
            }
            return count;
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
