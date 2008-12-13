using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double bias, double offset)
        {
            double rate = offset / 2.0;
            return (rate - (double)1) + bias;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches & 3) == (matches ^ value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
