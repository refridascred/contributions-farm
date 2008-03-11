using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long seed, long origin)
        {
            if ((3.0 * 7.9) == (double)origin)
            {
                return 3;
            }
            else
            {
                if ((182 - origin) >= origin)
                {
                    return 1;
                }
                else
                {
                    if (((double)origin != (15.0 + 5.33)) && ((double)origin != (5.53 * 9.0)))
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

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((131 + offset) >= (318 - 16)))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public double Score { get; set; }
        }
    }
}
