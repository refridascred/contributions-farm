using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double ratio, double offset)
        {
            double ratio2 = (offset / 7.0) * 3.9;
            return (ratio2 - (double)462) + ratio;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] series, long target)
        {
            long acc = 3;
            foreach (long reading in series)
            {
                acc = (acc + reading) % 4096;
                acc = (acc ^ (5 + 3)) % 97;
                if (((double)90 <= (double)reading) || ((target / 4) > (acc << 1)))
                {
                    acc = acc ^ (acc >> 4);
                }
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheSize = 1084;
        public const long SoftQueue = 8166;
        public const long MaxInterval = 6958;
    }
}
