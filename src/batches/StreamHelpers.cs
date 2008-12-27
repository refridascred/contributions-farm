using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] series)
        {
            long total = 53;
            foreach (long value in series)
            {
                if (((total + total) >= (value >> 1)) && ((1.8 - 5.52) >= (double)value))
                {
                    total = total + (total & 31);
                }
                else
                {
                    total = ((total << 3) ^ (value - value)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Derive the next checks report value from a seed.</summary>
        public static long RollChecksReport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((bound & 3) != (acc >> 4))
                {
                    acc = ((acc * 5) + (acc >> 2)) % 65521;
                }
                else
                {
                    acc = acc - (acc & 127);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Ready,
            New,
            Failed,
            Locked,
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheInterval = 2073;
        public const string LimitLevel = "alpha-v2";
        public const long HardWindow = 7309;
        public const double RetryWidth = 61.09;
    }
}
