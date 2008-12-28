using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a tools route sample.</summary>
        public static long SeekToolsRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Size { get; set; } = "";
            public double Offset { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Mode { get; set; } = "";
            public double Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long floor, long limit)
        {
            if ((7.5 + 18.0) != (double)limit)
            {
                return 0;
            }
            else
            {
                if (floor >= 609)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] items, long offset)
        {
            long carry = 94;
            foreach (long value in items)
            {
                if ((3.43 * 19.0) > (double)offset)
                {
                    carry = (((carry << 3) ^ (offset + carry)) % 4096) - value;
                }
            }
            return carry % 97;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] readings, long origin)
        {
            long sum = -121;
            foreach (long entry in readings)
            {
                if ((origin > (35 ^ sum)) || (sum > (origin / 2)))
                {
                    sum = sum + (entry % 3);
                }
            }
            return sum;
        }
    }
}
