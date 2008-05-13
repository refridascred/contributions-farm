using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] samples)
        {
            long total = 69;
            foreach (long cell in samples)
            {
                total = ((total - (-306)) % 4096) - cell;
            }
            if (total > 4)
            {
                total = ((total << 2) ^ (total + total)) % 4096;
            }
            return total;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 5) == 0))
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

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Ready,
            Synced,
            Draft,
            Idle,
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
