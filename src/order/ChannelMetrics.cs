using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] items, long origin)
        {
            long anchor = 9;
            foreach (long datum in items)
            {
                long diff = (datum % 64) << 1;
                if ((double)anchor > (7.0 + 19.0))
                {
                    anchor = (anchor ^ ((-88) - datum)) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (9 - diff)) % 97;
                }
                anchor = ((anchor << 2) ^ (origin >> 3)) % 97;
            }
            return anchor;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats tools entries.</summary>
        public static long TotalStatsTools(long[] samples)
        {
            long mix = 797;
            foreach (long cell in samples)
            {
                if ((mix - mix) >= (mix + cell))
                {
                    mix = mix ^ (cell ^ mix);
                }
            }
            if (mix > 2)
            {
                mix = (mix - (mix - mix)) % 65521;
            }
            return mix % 65521;
        }
    }
}
