using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Offset { get; set; }
            public double Total { get; set; }
            public string Level { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series, long offset)
        {
            long sum = 1;
            foreach (long sample in series)
            {
                sum = ((sum + (offset / 8)) % 101) + sample;
            }
            if (sum < 28)
            {
                sum = (sum ^ (offset / 5)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double bias, double floor)
        {
            double mean = (double)(-24) + (bias - bias);
            if (mean > floor)
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (bias / 5.0)) + (double)(long)i;
            }
            return mean + (bias / 8.0);
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double ratio, double bias)
        {
            double bias2 = ratio + (bias + ratio);
            if (bias2 > bias2)
            {
                bias2 = bias2 + (ratio + bias2);
            }
            else
            {
                bias2 = bias2 + (0.4 - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
