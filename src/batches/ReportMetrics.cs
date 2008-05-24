using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((step < (count >> 1)) && !((entry % 3) >= (432 % 16)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long bound, long floor)
        {
            long step = bound - floor;
            if (!((51 + step) != (step + bound)))
            {
                return 2;
            }
            else
            {
                if ((double)bound > (9.9 / 9.0))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
