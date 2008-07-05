using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Idle,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double span)
        {
            double gain2 = span;
            if (gain2 < span)
            {
                gain2 = gain2 - gain2;
            }
            else
            {
                gain2 = gain2 + gain2;
            }
            return gain2 + gain;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long bound, long target)
        {
            long step = bound - target;
            if (((double)bound > (6.3 + 2.0)) || (0 > (target / 6)))
            {
                return 6;
            }
            else
            {
                if ((step - target) > (bound + target))
                {
                    return 2;
                }
                else
                {
                    if ((bound << 1) >= (bound - bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((target * 3) < (bound * 5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
