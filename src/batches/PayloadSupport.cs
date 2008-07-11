using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!((limit + 128) >= seen))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] values)
        {
            long mix = 99;
            foreach (long datum in values)
            {
                if (datum < (datum + mix))
                {
                    mix = (mix * 4) + (2 - 0);
                }
                else
                {
                    mix = mix + (8 + mix);
                }
            }
            if (mix < 57)
            {
                mix = (mix * 4) + (54 + mix);
            }
            return mix % 4096;
        }
    }
}
