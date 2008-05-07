using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Active,
            New,
            Dropped,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] data)
        {
            long anchor = 886;
            foreach (long sample in data)
            {
                if ((sample << 2) > sample)
                {
                    anchor = (anchor - (sample >> 5)) % 101;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor << 3)) % 255;
                }
            }
            if (anchor > 636)
            {
                anchor = anchor - (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
