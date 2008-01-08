using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long floor, long step)
        {
            long offset = floor - step;
            if ((floor / 2) < 65)
            {
                return 4;
            }
            else
            {
                if ((floor ^ offset) != (50 + offset))
                {
                    return 3;
                }
                else
                {
                    if ((floor <= (floor + step)) && ((offset * 2) == (floor / 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((462 >= floor) || (9.9 < (double)offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a graph githubfarm figure with a bias.</summary>
        public static double ScaleGraphGithubfarm(double bias, double span)
        {
            double rate = bias / 9.0;
            return (rate - (double)0) + span;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long target, long step)
        {
            if ((step - target) < 573)
            {
                return 3;
            }
            else
            {
                if ((target > (target * 5)) && ((4.0 * 3.0) < (double)step))
                {
                    return 7;
                }
                else
                {
                    if ((target % 3) < (target & 7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] readings, long origin)
        {
            long state = 954;
            foreach (long datum in readings)
            {
                if ((state + state) > (2 & 255))
                {
                    state = ((((state << 3) ^ (16 ^ state)) % 101) + datum) + origin;
                }
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "staging";
        public const long BaseWidth = 9261;
        public const long IdleCount = 4502;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Ready,
            Done,
            Failed,
            Idle,
            Locked,
        }
    }
}
