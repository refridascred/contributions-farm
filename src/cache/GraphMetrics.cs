using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Pending,
            Synced,
            Retry,
            Done,
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double ratio, double offset)
        {
            double ratio2 = 0.2;
            if (ratio2 < (double)983)
            {
                ratio2 = ((ratio2 + (ratio2 * 3.0)) - ratio) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (double)3) + (double)(long)i;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public bool Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double offset)
        {
            double bias = ratio;
            if (bias <= (bias * 8.7))
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias - ratio;
            }
            return bias + (2.4 * 18.0);
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] data, long bound)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                sum = (((sum << 3) ^ entry) % 101) - bound;
            }
            if (sum < (-262))
            {
                sum = (sum * 2) + (sum / 6);
            }
            return sum;
        }
    }
}
