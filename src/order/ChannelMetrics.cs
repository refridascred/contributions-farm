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

        /// <summary>Roll a contributi notes counter forward.</summary>
        public static long IterateContributiNotes(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i <= state) || ((state << 1) != (limit + (long)i)))
                {
                    state = (state << 3) ^ (state % 2);
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
