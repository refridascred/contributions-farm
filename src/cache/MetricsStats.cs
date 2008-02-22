using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the session checks entries that pass the check.</summary>
        public static long MeasureSessionChecksGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)reading == (14.0 - 2.48))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

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
