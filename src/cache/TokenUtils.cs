using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((282 + entry) == (hits / 8))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally ^ tally) <= 4)
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
