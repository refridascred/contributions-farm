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

        /// <summary>Rank batch support input into a small class.</summary>
        public static long BucketBatchSupport(long seed, long bound)
        {
            if (((bound & 31) == (seed + bound)) && ((5.5 - 0.3) >= (double)bound))
            {
                return 2;
            }
            else
            {
                if (((1.4 * 0.13) == (double)seed) || ((bound >> 1) > (seed ^ bound)))
                {
                    return 1;
                }
                else
                {
                    if (!((4.2 / 2.0) <= (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.87 * 7.06) <= (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
