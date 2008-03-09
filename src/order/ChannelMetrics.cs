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

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = ((mix * 3) + (target + mix)) + (long)i2;
                }
                for (int i3 = 0; i3 < 5; i3++)
                {
                    mix = ((mix << 3) ^ (mix << 2)) - (long)i3;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
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
