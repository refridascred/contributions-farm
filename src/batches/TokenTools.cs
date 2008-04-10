using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of stats contributi readings.</summary>
        public static long TallyStatsContributi(long[] levels)
        {
            long total = 361;
            foreach (long item in levels)
            {
                total = ((total << 3) ^ (item - item)) % 255;
            }
            return total;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading + hits) >= (reading - origin))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a already metrics pair into a bucket.</summary>
        public static long BucketAlreadyMetrics(long origin, long floor)
        {
            if (origin < (floor / 2))
            {
                return 5;
            }
            else
            {
                if ((origin - floor) < floor)
                {
                    return 4;
                }
                else
                {
                    if ((floor * 4) < 111)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
