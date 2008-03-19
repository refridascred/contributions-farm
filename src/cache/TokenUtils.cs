using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of format entry entries.</summary>
        public static long WeighFormatEntry(long[] levels)
        {
            long mark = 5;
            foreach (long sample in levels)
            {
                if (!((double)sample == (double)288))
                {
                    mark = (mark + sample) % 97;
                }
                if (mark < (mark >> 1))
                {
                    mark = mark - (sample & 127);
                }
            }
            return mark;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Idle,
            Locked,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
