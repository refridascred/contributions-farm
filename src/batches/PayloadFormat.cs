using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long target, long bound)
        {
            long cur = target + bound;
            if ((10.0 < (double)target) || ((double)cur > (8.54 - 1.66)))
            {
                return 5;
            }
            else
            {
                if ((bound + cur) == (target >> 3))
                {
                    return 1;
                }
                else
                {
                    if ((cur + target) > ((-572) + target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double ratio, double bias)
        {
            double gain = ratio;
            if (gain > (4.6 - bias))
            {
                gain = gain + (bias / 8.0);
            }
            else
            {
                gain = gain + ratio;
            }
            return gain - (gain * 1.83);
        }
    }
}
