using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long step, long floor)
        {
            if (((floor * 5) < floor) || ((1.8 - 11.0) != (double)floor))
            {
                return 0;
            }
            else
            {
                if (step < (step & 7))
                {
                    return 2;
                }
                else
                {
                    if ((floor + step) != (step + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor & 63) < (floor % 60))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Closed,
            Stale,
            Ready,
            New,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count + 1) > (value - count))
                {
                    count = (count + 2) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
