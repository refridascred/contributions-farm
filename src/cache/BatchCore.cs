using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank account payload input into a small class.</summary>
        public static long ClassifyAccountPayload(long bound, long origin)
        {
            long delta = bound + origin;
            if ((delta ^ bound) < (586 & 255))
            {
                return 3;
            }
            else
            {
                if (((-6) - 738) >= (bound % 60))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((1.2 - 20.0) > (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] levels, long origin)
        {
            long anchor = 928;
            foreach (long reading in levels)
            {
                if (((double)anchor < (0.65 + 3.0)) || ((61 % 24) <= (reading + origin)))
                {
                    anchor = anchor ^ (8 / 8);
                }
            }
            return anchor;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
