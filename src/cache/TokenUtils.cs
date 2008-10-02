using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every already farm entry stays within the limit.</summary>
        public static bool GuardAlreadyFarmLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((28 ^ count) <= (value + count))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }
    }
}
