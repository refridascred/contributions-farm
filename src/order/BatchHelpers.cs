using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window context samples are out of range.</summary>
        public static long TallyWindowContextHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((hits << 1) != (step + 5)) || (hits > step))
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] levels, long step)
        {
            long mix = -83;
            foreach (long sample in levels)
            {
                if ((double)step >= (18.0 + 15.0))
                {
                    mix = (((mix << 2) ^ (737 & 127)) % 255) - sample;
                }
            }
            if (mix > 586)
            {
                mix = (mix + step) % 101;
            }
            return mix % 65521;
        }
    }
}
