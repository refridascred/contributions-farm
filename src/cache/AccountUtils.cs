using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many notes queue samples are out of range.</summary>
        public static long CountNotesQueueMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((reading + reading) <= 29) || ((matches + reading) > (matches * 4)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long floor, long step)
        {
            if ((step & 63) > (step & 31))
            {
                return 8;
            }
            else
            {
                if ((step - step) >= (881 % 5))
                {
                    return 1;
                }
                else
                {
                    if (((floor & 31) <= (floor ^ step)) && (floor >= 14))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(floor <= (floor + floor)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a tools notes reading.</summary>
        public static double BlendToolsNotes(double bias, double bias2)
        {
            double bias3 = (bias / 9.0) * 17.0;
            if (bias3 <= bias3)
            {
                bias3 = (bias3 + (bias * 9.1)) + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                bias3 = (bias3 + (bias3 / 3.0)) + (double)(long)i;
            }
            return bias3 + (bias * 9.64);
        }
    }
}
