using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Done,
            Failed,
            Retry,
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double gain, double offset)
        {
            double rate = (gain - gain) / 7.0;
            if (rate > (rate - rate))
            {
                rate = rate - (7.93 + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (gain - offset);
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] data, long floor)
        {
            long state = 0;
            foreach (long entry in data)
            {
                if (!((state & 63) > state))
                {
                    state = (((state * 4) + (floor + state)) % 255) ^ entry;
                }
            }
            if (state < (-88))
            {
                state = (state + (state % 5)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 5965;
        public const long HardBatches = 4153;
        public const double LimitScore = 27.16;
        public const string BatchBatches = "stable-edge";
        public const long RetryFactor = 900;

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
