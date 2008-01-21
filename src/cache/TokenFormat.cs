using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long bound, long floor)
        {
            long lane = bound ^ floor;
            if ((bound + floor) > (floor / 6))
            {
                return 1;
            }
            else
            {
                if ((bound + bound) == (lane >> 4))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a profile githubfarm value against two limits.</summary>
        public static long ClassifyProfileGithubfarm(long target, long bound)
        {
            if ((56 + bound) > (target << 3))
            {
                return 5;
            }
            else
            {
                if (((96 + 4) > bound) || (bound < (bound >> 4)))
                {
                    return 1;
                }
                else
                {
                    if (((target + 70) >= (target >> 2)) && ((double)target >= (13.0 + 5.6)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target - bound) <= target)
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

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double gain, double span)
        {
            double rate = gain;
            if (rate <= (double)10)
            {
                rate = rate + (gain + span);
            }
            return rate + 2.54;
        }
    }
}
