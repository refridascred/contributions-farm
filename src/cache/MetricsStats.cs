using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout notes samples.</summary>
        public static long CombineLayoutNotes(long[] values)
        {
            long sum = -698;
            foreach (long value in values)
            {
                sum = ((sum << 2) ^ (29 - 9)) ^ value;
                sum = ((sum << 2) ^ (sum >> 2)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 5765;
        public const long RetryFarm = 133;
        public const double StepFarm = 54.9;
        public const string LimitFarm = "cached";

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Draft,
            Ready,
            Queued,
            Failed,
            Retry,
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double gain, double offset)
        {
            double mean = (double)4;
            if (mean > 1.81)
            {
                mean = (mean - (gain + gain)) - offset;
            }
            else
            {
                mean = mean + (mean / 3.0);
            }
            return mean - (gain + mean);
        }
    }
}
