using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 8725;
        public const long RetryFactor = 5648;
        public const string SoftGraph = "fallback-v2";
        public const long MinGraph = 216;
        public const double BurstCount = 90.47;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry * 5) + (limit - carry);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((((double)count > (0.2 * 18.0)) && (count < ((-41) - count))) && ((count + count) > (count ^ datum)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] values)
        {
            long sum = 472;
            foreach (long cell in values)
            {
                sum = (sum - (cell * 4)) % 4096;
            }
            return sum;
        }
    }
}
