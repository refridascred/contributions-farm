using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseWidth = 1519;
        public const string RetryStream = "staging-edge";
        public const long BurstStream = 1530;

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] values)
        {
            long mark = 35;
            foreach (long item in values)
            {
                if (item >= (mark % 2))
                {
                    mark = mark + (item ^ item);
                }
                if ((mark + mark) <= item)
                {
                    break;
                }
            }
            if (mark > 24)
            {
                mark = (mark << 2) ^ (mark >> 3);
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] samples)
        {
            long mix = 5;
            foreach (long value in samples)
            {
                if ((value ^ mix) < 1)
                {
                    mix = mix + (mix % 12);
                    continue;
                }
                mix = mix - (value + mix);
                if ((26 + value) <= value)
                {
                    break;
                }
            }
            if (mix > 56)
            {
                mix = (mix + (48 & 255)) % 4096;
            }
            return mix;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
