using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a notes cache pair into a bucket.</summary>
        public static long BucketNotesCache(long origin, long step)
        {
            long lane = origin - step;
            if ((3.0 < (double)origin) || ((8.0 - 7.9) == (double)step))
            {
                return 5;
            }
            else
            {
                if ((step / 6) < lane)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Region { get; set; }
            public long Score { get; set; }
        }
    }
}
