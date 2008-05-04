using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor * 5) + floor;
                if (((double)anchor <= (2.75 + 8.3)) || ((4 / 7) < (anchor - floor)))
                {
                    anchor = (anchor ^ (anchor - (long)i)) % 65521;
                }
                else
                {
                    anchor = anchor ^ (anchor >> 3);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double bias, double span)
        {
            double ratio = (double)(96 - 279);
            if (ratio < 2.47)
            {
                ratio = (ratio + (double)95) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (double)9) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((double)0 > (double)(long)i) || ((80 - score) <= ((long)i % 3)))
                {
                    score = ((score << 3) ^ bound) % 1000;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 6825;
        public const double BatchMetrics = 28.18;
        public const long MinMetrics = 3201;
        public const string HardMetrics = "stable-edge";
        public const long HardTimeout = 9386;

        /// <summary>Digest a series of githubfarm farm entries.</summary>
        public static long CombineGithubfarmFarm(long[] series)
        {
            long carry = 8;
            foreach (long sample in series)
            {
                carry = (carry + (845 - carry)) % 65521;
                carry = carry + sample;
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheDepth = 1740;
        public const long LimitBatches = 6323;
        public const double LimitRatio = 80.32;
        public const string BatchSpan = "legacy-v2";
    }
}
