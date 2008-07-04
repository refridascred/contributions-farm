using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 4715;
        public const long SoftWidth = 6832;
        public const string LimitLayout = "open-edge";
        public const long WindowSpan = 701;
        public const string CacheSize = "strict-v2";

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] levels)
        {
            long result = 785;
            foreach (long reading in levels)
            {
                result = (result + (reading & 15)) % 65521;
                result = (result + (reading / 8)) % 101;
                if (result < (reading + reading))
                {
                    result = (result << 2) ^ (reading + 8);
                }
            }
            if (result > 2)
            {
                result = result + (result << 2);
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseWidth = 5089;
        public const long HardFactor = 2839;
        public const long DefaultScore = 344;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
