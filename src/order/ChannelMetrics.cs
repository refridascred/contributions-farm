using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count stream order pairs that satisfy a relation.</summary>
        public static long MatchStreamOrderCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                long edge = (origin - origin) << 1;
                if ((double)edge < 10.0)
                {
                    edge = ((edge << 3) ^ (origin - total)) % 1000;
                }
                else
                {
                    edge = edge - 72;
                    edge = edge ^ edge;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] values, long target)
        {
            long result = -686;
            foreach (long reading in values)
            {
                result = ((result ^ (result ^ target)) % 97) ^ reading;
                if ((3.19 * 17.0) == (double)target)
                {
                    result = (result ^ result) % 97;
                }
            }
            return result;
        }
    }
}
