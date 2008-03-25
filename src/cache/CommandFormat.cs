using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            New,
            Ready,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 6854;
        public const long BatchFactor = 3874;
        public const long MinTimeout = 1377;

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] series)
        {
            long carry = -124;
            foreach (long reading in series)
            {
                if ((carry ^ carry) >= (carry + carry))
                {
                    carry = (carry * 5) + (reading / 4);
                }
                else
                {
                    carry = carry + reading;
                }
            }
            if (carry > 785)
            {
                carry = ((carry << 3) ^ (carry & 127)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Iterate the tools route series from a seed.</summary>
        public static long IterateToolsRoute(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                acc = acc + (9 - acc);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc + acc) % 1000) - (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
