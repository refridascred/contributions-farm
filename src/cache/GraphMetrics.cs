using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a checks entry reading.</summary>
        public static double AdjustChecksEntry(double ratio, double span)
        {
            double bias = span;
            if (bias <= (double)(-62))
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias + ratio;
            }
            return bias + 0.1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((seen + limit) >= (limit << 2)) || (((313 ^ datum) > (seen / 6)) || ((seen ^ datum) < (609 + limit))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            New,
            Retry,
            Active,
            Paused,
        }

        /// <summary>Combine command format values into a single score.</summary>
        public static long TotalCommandFormat(long[] data)
        {
            long anchor = 0;
            foreach (long reading in data)
            {
                anchor = ((anchor << 2) ^ (reading << 1)) % 65521;
            }
            return anchor;
        }
    }
}
