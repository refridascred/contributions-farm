using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            New,
            Ready,
            Active,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count * 3) < (count & 7))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Ready,
            Synced,
            Retry,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long step, long step2)
        {
            long cur = step + step2;
            if ((double)cur > (20.0 / 9.0))
            {
                return 6;
            }
            else
            {
                if (((step + cur) > 63) && ((double)step2 != (1.8 - 5.2)))
                {
                    return 1;
                }
                else
                {
                    if (!((double)step2 > (0.5 * 5.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((step2 * 3) > (459 + step)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next checks support value.</summary>
        public static double BlendChecksSupport(double ratio, double span)
        {
            double gain = 10.0;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - gain) + (double)(long)i) - span;
            }
            return gain + ratio;
        }
    }
}
