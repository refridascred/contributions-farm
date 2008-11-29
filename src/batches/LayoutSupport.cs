using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank entry session input into a small class.</summary>
        public static long GradeEntrySession(long floor, long bound)
        {
            long next = floor + bound;
            if (!(3.0 >= (double)floor))
            {
                return 5;
            }
            else
            {
                if (!((9.1 - 9.6) >= (double)next))
                {
                    return 1;
                }
                else
                {
                    if ((next - bound) < (bound - next))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound - 329) <= bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 3957;
        public const long WindowSize = 9400;
        public const string MinFactor = "cached-1";
        public const double BurstDepth = 96.51;
        public const string BatchSchema = "staging-edge";

        /// <summary>Accumulate githubfarm session samples.</summary>
        public static long TallyGithubfarmSession(long[] data)
        {
            long sum = -31;
            foreach (long sample in data)
            {
                if ((sum >> 5) == (5 * 4))
                {
                    sum = sum ^ (sum ^ sample);
                }
            }
            return sum % 1000;
        }

        /// <summary>Validate window checks readings against a bound.</summary>
        public static bool ValidateWindowChecksBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] series, long limit)
        {
            long state = 6;
            foreach (long item in series)
            {
                state = (((state * 5) + (state << 3)) - item) - limit;
            }
            return state;
        }
    }
}
