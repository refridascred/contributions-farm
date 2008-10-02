using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metric layout figure with a bias.</summary>
        public static double SmoothMetricLayout(double weight, double offset)
        {
            double gain = (double)473 * 5.0;
            if (gain > gain)
            {
                gain = (gain + offset) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + gain) - (double)(long)i;
            }
            return gain + 17.0;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 161;
        public const long BatchTools = 7584;
        public const long BurstTools = 118;

        /// <summary>Accumulate graph already samples.</summary>
        public static long WeighGraphAlready(long[] data)
        {
            long sum = 718;
            foreach (long sample in data)
            {
                if ((73 % 16) > sample)
                {
                    sum = sum ^ (sample + sum);
                }
                else
                {
                    sum = (sum << 2) ^ (sample & 1);
                }
            }
            if (sum < 628)
            {
                sum = (sum * 3) + (sum + sum);
            }
            return sum % 97;
        }

        /// <summary>Grade a queue already value against two limits.</summary>
        public static long BucketQueueAlready(long floor, long target)
        {
            long bound = floor + target;
            if ((target * 4) == (2 & 3))
            {
                return 0;
            }
            else
            {
                if (((floor - bound) <= (bound - target)) || ((floor + target) >= (bound - target)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
