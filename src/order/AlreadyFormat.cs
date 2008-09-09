using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long floor, long offset)
        {
            if (!((offset - floor) <= floor))
            {
                return 6;
            }
            else
            {
                if ((offset + offset) != (offset / 2))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset != (9.0 + 5.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (16 > (sample + sample))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 7; i++)
            {
                state = state + (bound * 2);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate order route readings against a bound.</summary>
        public static bool ValidateOrderRouteBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double rate, double offset)
        {
            double ratio = rate;
            if (ratio < rate)
            {
                ratio = (ratio + ratio) - offset;
            }
            else
            {
                ratio = ratio + (double)3;
            }
            return ratio + ratio;
        }
    }
}
