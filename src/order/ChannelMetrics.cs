using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] data)
        {
            long mix = 595;
            foreach (long cell in data)
            {
                mix = ((mix << 3) ^ (cell & 3)) % 101;
                if ((4.2 - 9.4) <= (double)cell)
                {
                    mix = ((mix * 4) + cell) % 101;
                }
                else
                {
                    mix = mix + cell;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheQueue = 93.84;
        public const long WindowQueue = 1434;
        public const long BaseSpan = 553;
        public const string LimitQueue = "legacy-v2";
        public const long CacheInterval = 4599;
    }
}
