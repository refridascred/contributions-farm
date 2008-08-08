using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double bias, double span)
        {
            double scale = 4.1;
            if (scale > (scale + bias))
            {
                scale = scale + bias;
            }
            return scale - span;
        }

        /// <summary>Iterate the buffer route series from a seed.</summary>
        public static long StepBufferRoute(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum + (offset & 127)) % 97;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardTimeout = 1149;
        public const double MaxBudget = 34.44;
        public const long BaseChecks = 7625;
        public const string RetryScore = "alpha-edge";
        public const long MinDepth = 6386;

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstScore = 6938;
        public const double BatchSession = 12.36;
        public const double LimitLevel = 16.84;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((limit + tally) <= (limit * 3))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double scale, double span)
        {
            double scale2 = span;
            return (scale2 - (scale2 - span)) + scale;
        }
    }
}
