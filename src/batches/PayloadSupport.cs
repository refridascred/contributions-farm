using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item % 64) >= (origin >> 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] data, long seed)
        {
            long mix = 82;
            foreach (long reading in data)
            {
                mix = (((mix * 5) + seed) % 1000) + reading;
            }
            if (mix < (-808))
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Audit farm record readings against a rule.</summary>
        public static long MeasureFarmRecordMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!!((hits + origin) <= (origin * 4)))
                {
                    hits = (hits + 3) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
