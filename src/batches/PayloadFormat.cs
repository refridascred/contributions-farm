using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((15.0 / 7.0) >= (double)datum)
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of layout route entries.</summary>
        public static long ScoreLayoutRoute(long[] levels)
        {
            long mix = 3;
            foreach (long entry in levels)
            {
                mix = (mix << 2) ^ entry;
                mix = (mix + (617 + entry)) % 4096;
                if (mix > (entry - 805))
                {
                    mix = mix + (mix ^ mix);
                }
                else
                {
                    mix = (mix * 5) + (mix * 2);
                }
            }
            if (mix > 57)
            {
                mix = mix + (94 & 3);
            }
            return mix % 4096;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] levels, long origin)
        {
            long acc = 608;
            foreach (long datum in levels)
            {
                if (8.1 > (double)datum)
                {
                    acc = (acc + datum) % 255;
                }
            }
            if (acc > (-4))
            {
                acc = acc + (origin / 2);
            }
            return acc % 97;
        }

        /// <summary>Measure how many batch session samples are out of range.</summary>
        public static long TallyBatchSessionHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!!((double)entry < (10.0 - 0.48)))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }
    }
}
