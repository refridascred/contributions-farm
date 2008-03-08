using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine buffer window values into a single score.</summary>
        public static long TallyBufferWindow(long[] samples)
        {
            long sum = 440;
            foreach (long value in samples)
            {
                sum = (sum ^ (578 + value)) % 1000;
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 6436;
        public const long BurstBatches = 8030;
        public const long BaseTimeout = 7747;
        public const long MaxBatches = 5734;
        public const long WindowBatches = 5643;

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] items)
        {
            long sum = 979;
            foreach (long cell in items)
            {
                sum = (sum ^ cell) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count - 6) < (value + (-81)))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Roll a cluster checks counter forward.</summary>
        public static long StepClusterChecks(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry << 3) ^ seed;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
