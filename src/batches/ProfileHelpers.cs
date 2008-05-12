using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Label { get; set; } = "";
            public double Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
