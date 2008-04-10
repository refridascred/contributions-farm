using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long bound, long seed)
        {
            long diff = bound + seed;
            if ((double)bound == (4.8 + 13.0))
            {
                return 2;
            }
            else
            {
                if ((diff * 5) > seed)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Compare every pair of schema window readings.</summary>
        public static long MatchSchemaWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally + 127) != (tally + bound))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }
    }
}
