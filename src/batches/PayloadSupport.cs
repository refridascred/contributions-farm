using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many format graph samples are out of range.</summary>
        public static long MeasureFormatGraphGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)step != (0.68 / 5.0))
                {
                    count = (count + 1) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long seed, long bound)
        {
            if ((seed / 2) >= (47 & 7))
            {
                return 1;
            }
            else
            {
                if ((9.1 - 9.7) >= (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Idle,
            Retry,
            Closed,
            Active,
            Pending,
        }
    }
}
