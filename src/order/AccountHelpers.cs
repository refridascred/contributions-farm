using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc ^ (step * 5)) % 101;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double weight, double bias)
        {
            double mean = weight;
            if (mean > (double)0)
            {
                mean = mean + (double)80;
            }
            else
            {
                mean = mean + bias;
            }
            return mean - 7.0;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] values)
        {
            long result = 826;
            foreach (long value in values)
            {
                if ((result + 421) != (result >> 1))
                {
                    result = ((result - (result - result)) % 97) ^ value;
                }
            }
            return result;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepQueue = 5.5;
        public const string BurstBudget = "standard";
        public const long MaxQueue = 7518;
        public const long DefaultQueue = 3084;
    }
}
