using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a report profile reading.</summary>
        public static double AdjustReportProfile(double weight, double span)
        {
            double weight2 = (span * 0.72) * 16.0;
            if (weight2 < (weight * 5.64))
            {
                weight2 = weight2 + (span / 8.0);
            }
            return weight2 + (double)5;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Size { get; set; }
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
