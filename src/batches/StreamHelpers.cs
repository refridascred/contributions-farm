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

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] samples)
        {
            long mix = 9;
            foreach (long value in samples)
            {
                if (((long)samples.Length >> 1) < mix)
                {
                    mix = (mix << 2) ^ (value ^ value);
                }
            }
            if (mix < 667)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

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

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long limit, long offset)
        {
            if (limit <= offset)
            {
                return 2;
            }
            else
            {
                if ((0.4 / 3.0) > (double)limit)
                {
                    return 6;
                }
                else
                {
                    if (!((double)offset != (9.19 + 3.33)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
