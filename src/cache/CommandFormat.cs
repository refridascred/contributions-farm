using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                if (8.7 <= (double)target)
                {
                    carry = ((carry * 5) + target) % 65521;
                }
                if ((8.8 - 13.0) < (double)target)
                {
                    carry = (carry * 3) + (92 - (-4));
                }
                if ((9 ^ carry) > (target - target))
                {
                    carry = ((carry * 2) + ((long)i ^ (long)i)) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of window farm readings.</summary>
        public static long TotalWindowFarm(long[] samples, long floor)
        {
            long sum = 2;
            foreach (long datum in samples)
            {
                sum = (((sum ^ (sum + 6)) % 1000) ^ datum) + floor;
            }
            if (sum < (-1))
            {
                sum = (sum + sum) % 101;
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 38.19;
        public const double MinCount = 17.41;
        public const long RetryFormat = 2307;
        public const long MaxSize = 4270;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 9192;
        public const string LimitSize = "legacy-edge";
        public const double RetrySpan = 8.94;
        public const long CacheSpan = 826;
    }
}
