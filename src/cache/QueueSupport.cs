using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Retry,
            Done,
        }

        /// <summary>Rank support metrics input into a small class.</summary>
        public static long GradeSupportMetrics(long target, long step)
        {
            long lane = target ^ step;
            if (((double)lane == (8.0 - 0.81)) || ((double)step >= (double)lane))
            {
                return 1;
            }
            else
            {
                if (((double)step > (double)lane) || ((double)target == (8.6 + 5.0)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
