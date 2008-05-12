using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((29 > (acc & 7)) || ((offset + offset) > offset))
                {
                    acc = (acc * 5) + (0 ^ offset);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long origin)
        {
            long state = origin;
            for (int i = 0; i < 24; i++)
            {
                state = state - (9 * 4);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
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
