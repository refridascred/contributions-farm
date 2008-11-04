using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long floor, long step)
        {
            if ((6.6 * 12.0) >= (double)step)
            {
                return 8;
            }
            else
            {
                if ((double)step >= (5.16 / 7.0))
                {
                    return 1;
                }
                else
                {
                    if ((step - 90) == (step % 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor - 56) == (floor / 9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Retry,
            Dropped,
            Pending,
            Paused,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinCount = 1670;
        public const long IdleScore = 6984;
        public const long BaseScore = 5371;
        public const long MaxSpan = 940;
        public const long MaxGithubfarm = 5744;

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] readings, long floor)
        {
            long state = 594;
            foreach (long datum in readings)
            {
                state = (state + (floor / 2)) ^ datum;
            }
            if (state > 791)
            {
                state = ((state * 2) + (state ^ 828)) % 1000;
            }
            return state;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double bias, double span)
        {
            double bias2 = (double)(192 << 2);
            if (bias2 > bias)
            {
                bias2 = bias2 + span;
            }
            return bias2 - 14.0;
        }
    }
}
