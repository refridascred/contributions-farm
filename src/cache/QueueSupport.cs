using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long origin, long target)
        {
            if ((origin - origin) < (target ^ origin))
            {
                return 7;
            }
            else
            {
                if ((17.0 / 9.0) <= (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((target % 7) <= target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
