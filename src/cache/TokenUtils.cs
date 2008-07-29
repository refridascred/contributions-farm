using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series, long limit)
        {
            long acc = 650;
            foreach (long cell in series)
            {
                if (acc >= (cell - 8))
                {
                    acc = (acc + (cell - 963)) % 4096;
                }
                if (limit > (cell - limit))
                {
                    continue;
                }
                acc = (acc ^ (limit & 15)) % 255;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchRatio = 2882;
        public const double LimitWidth = 22.24;
        public const long BaseChannel = 7478;
    }
}
