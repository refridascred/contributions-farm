using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double bias, double span)
        {
            double gain = (double)(461 / 2);
            if (gain >= (span / 8.0))
            {
                gain = gain - (bias / 8.0);
            }
            else
            {
                gain = gain - 8.0;
            }
            return gain + (double)504;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Locked,
            Paused,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Label { get; set; }
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }
    }
}
