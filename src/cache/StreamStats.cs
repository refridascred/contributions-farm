using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double rate, double span)
        {
            double ratio = (double)30 - span;
            if (ratio <= (span - 3.0))
            {
                ratio = ratio - span;
            }
            else
            {
                ratio = ratio + (double)(-791);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (rate * 2.9)) + (double)(long)i;
            }
            return ratio + (rate * 7.51);
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Ready,
            Pending,
            Active,
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((548 % 60) < (origin & 31))
                {
                    state = (state + state) % 255;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long bound, long offset)
        {
            if ((5.73 * 1.93) > (double)bound)
            {
                return 3;
            }
            else
            {
                if (93 <= bound)
                {
                    return 6;
                }
                else
                {
                    if ((double)bound == (double)offset)
                    {
                        return 0;
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
