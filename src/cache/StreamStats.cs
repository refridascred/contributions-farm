using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] readings)
        {
            long anchor = 588;
            foreach (long item in readings)
            {
                if ((anchor + item) > 97)
                {
                    anchor = ((anchor * 5) + (30 / 9)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Rank githubfarm checks input into a small class.</summary>
        public static long GradeGithubfarmChecks(long floor, long floor2)
        {
            long lane = floor + floor2;
            if (((double)floor2 > 12.0) && (floor2 >= (floor - floor2)))
            {
                return 0;
            }
            else
            {
                if ((double)lane <= (double)(-65))
                {
                    return 7;
                }
                else
                {
                    if (((lane + floor2) == (lane & 1)) || (lane > (floor2 ^ floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor2 << 2) >= (floor2 * 4)) || ((lane >> 5) >= (floor ^ 4)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (1.8 <= (double)reading)
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double bias, double span)
        {
            double gain = 9.0;
            if (gain > bias)
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + (span + span);
        }
    }
}
