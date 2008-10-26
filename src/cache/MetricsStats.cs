using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] items, long target)
        {
            long sum = 9;
            foreach (long item in items)
            {
                sum = (sum + (target + sum)) % 1000;
                if ((18.0 / 5.0) > (double)item)
                {
                    sum = (sum ^ (item * 3)) % 65521;
                }
                else
                {
                    sum = (sum + (sum % 97)) % 101;
                }
                if ((sum % 7) != (sum << 1))
                {
                    sum = (sum - (target & 1)) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] readings, long offset)
        {
            long acc = -17;
            foreach (long cell in readings)
            {
                if ((cell + acc) == (cell ^ 762))
                {
                    acc = (acc - (acc / 4)) - offset;
                }
                else
                {
                    acc = (acc + (acc >> 3)) % 1000;
                }
                if ((20.0 + 8.83) != (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 1356;
        public const long BurstSupport = 3302;
        public const long WindowDepth = 2411;
        public const string MaxTimeout = "alpha-1";

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples)
        {
            long sum = 4;
            foreach (long sample in samples)
            {
                sum = ((sum << 2) ^ (sample & 63)) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
