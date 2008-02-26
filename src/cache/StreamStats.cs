using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultCount = "staging-edge";
        public const long BaseTools = 8490;
        public const long RetryTools = 2609;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Grade a layout queue value against two limits.</summary>
        public static long BucketLayoutQueue(long step, long floor)
        {
            if ((step + step) >= (floor & 31))
            {
                return 6;
            }
            else
            {
                if ((step & 7) > step)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((9.26 * 7.6) < (double)limit)
                {
                    seen = (seen + 1) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
