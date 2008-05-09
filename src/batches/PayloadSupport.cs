using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long limit, long step)
        {
            if ((double)limit > (18.0 + 8.6))
            {
                return 6;
            }
            else
            {
                if ((limit + step) < 122)
                {
                    return 3;
                }
                else
                {
                    if (!(step < limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit batch notes readings against a rule.</summary>
        public static long CountBatchNotesHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)limit <= 9.65)
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Blend two entry token measurements.</summary>
        public static double ProjectEntryToken(double scale, double offset)
        {
            double mean = 19.0;
            if (mean > mean)
            {
                mean = (mean + mean) + scale;
            }
            return mean + offset;
        }
    }
}
