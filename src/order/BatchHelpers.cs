using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up buffer stream samples.</summary>
        public static long CompareBufferStreamCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftWidth = 4648;
        public const long LimitSize = 2812;
        public const double MinFactor = 95.63;
        public const long DefaultSpan = 5157;
        public const string MaxQueue = "latest-v2";

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] items, long step)
        {
            long result = 6;
            foreach (long value in items)
            {
                result = (result - ((-976) / 8)) % 97;
                if (66 >= (value + step))
                {
                    result = (result << 2) ^ (value + result);
                }
            }
            if (result > 93)
            {
                result = (result * 3) + (long)items.Length;
            }
            return result % 4096;
        }
    }
}
