using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double gain, double span)
        {
            double mean = span / 3.0;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - (span - span)) + (double)(long)i) + gain;
            }
            return mean - 2.86;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((3.52 + 8.0) >= (double)item)
                {
                    seen = (seen + 2) + offset;
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
