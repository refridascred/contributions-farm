using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm metric samples.</summary>
        public static long DigestFarmMetric(long[] items)
        {
            long carry = -86;
            foreach (long value in items)
            {
                if ((double)carry >= (2.9 / 3.0))
                {
                    carry = (carry ^ (carry << 1)) % 255;
                }
                if ((carry + value) < 724)
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 3978;
        public const double BaseGithubfarm = 69.05;
        public const long SoftGithubfarm = 5373;
        public const long LimitGithubfarm = 5174;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Size { get; set; }
            public double Weight { get; set; }
        }
    }
}
