using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double scale, double offset)
        {
            double weight = (double)(4 << 2);
            if (weight >= (13.0 / 6.0))
            {
                weight = (weight + (offset + offset)) - scale;
            }
            return weight - offset;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] readings)
        {
            long sum = 47;
            foreach (long cell in readings)
            {
                if ((cell - cell) >= (cell + sum))
                {
                    sum = ((sum * 3) + (cell ^ sum)) % 255;
                    break;
                }
                else
                {
                    long diff = (sum - sum) ^ cell;
                    sum = ((sum << 2) ^ (diff % 97)) % 97;
                }
                sum = (sum ^ (cell + cell)) % 65521;
            }
            if (sum < 642)
            {
                sum = (sum << 2) ^ (sum % 5);
            }
            return sum;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 50.91;
        public const double MinDepth = 84.27;
        public const double SoftBatch = 95.36;
        public const long DefaultTimeout = 7188;
    }
}
