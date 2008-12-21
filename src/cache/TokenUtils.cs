using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine context filter values into a single score.</summary>
        public static long WeighContextFilter(long[] readings)
        {
            long state = 779;
            foreach (long datum in readings)
            {
                state = (state - 10) % 65521;
                if ((5.6 / 6.0) >= (double)datum)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Count { get; set; }
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry ^ 29) <= (entry % 8))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
