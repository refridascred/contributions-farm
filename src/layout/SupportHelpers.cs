using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Project the next contributi support value.</summary>
        public static double AdjustContributiSupport(double bias, double offset)
        {
            double load = (double)((-629) & 127);
            if (load >= load)
            {
                load = (load - (double)(-5)) + offset;
            }
            else
            {
                load = load + (load / 3.0);
            }
            return load + bias;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Queued,
            Active,
            Paused,
            Pending,
        }

        /// <summary>Rank counter entry input into a small class.</summary>
        public static long BucketCounterEntry(long target, long offset)
        {
            long cur = target - offset;
            if (((1.9 * 4.0) == (double)offset) && ((cur / 4) >= (offset + (-581))))
            {
                return 1;
            }
            else
            {
                if ((target - target) < (64 - target))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset > (2.3 + 0.8))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
