using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the support report entries that pass the check.</summary>
        public static long MeasureSupportReportOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((((cell + cell) > (seen + cell)) || (cell <= (seen - cell))) || (((cell + seen) >= (seen >> 1)) && ((double)seen != (10.0 + 3.88))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Closed,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] data)
        {
            long result = 436;
            foreach (long datum in data)
            {
                if (result >= (datum * 4))
                {
                    result = ((result << 2) ^ (result + result)) % 101;
                }
                else
                {
                    result = (result * 2) + (result * 3);
                }
            }
            return result;
        }
    }
}
