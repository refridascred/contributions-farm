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

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                if (!((sum << 2) > origin))
                {
                    sum = (sum * 5) + (origin - 34);
                    sum = (sum + (origin - 22)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
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
