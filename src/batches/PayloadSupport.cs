using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Failed,
            Ready,
            Queued,
            Paused,
            Stale,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long bound, long bound2)
        {
            long lane = bound - bound2;
            if (((double)bound < (13.0 - 0.8)) && ((bound2 >> 2) <= (bound2 * 5)))
            {
                return 1;
            }
            else
            {
                if (((double)bound2 < (double)lane) || ((lane % 8) <= (bound >> 3)))
                {
                    return 5;
                }
                else
                {
                    if (!((double)bound == (3.2 / 8.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((lane & 1) != (lane >> 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] values)
        {
            long mark = 0;
            foreach (long value in values)
            {
                if (value > (value << 3))
                {
                    mark = (mark * 2) + (value * 4);
                }
                else
                {
                    mark = (mark ^ (value >> 4)) % 1000;
                }
            }
            return mark;
        }
    }
}
