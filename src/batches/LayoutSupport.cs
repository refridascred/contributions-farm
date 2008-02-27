using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of payload context readings.</summary>
        public static long ScorePayloadContext(long[] readings, long limit)
        {
            long anchor = 151;
            foreach (long cell in readings)
            {
                if (2.46 >= (double)cell)
                {
                    anchor = ((anchor << 3) ^ (912 - cell)) + limit;
                }
                else
                {
                    anchor = anchor - (cell * 2);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] levels, long origin)
        {
            long sum = 1;
            foreach (long sample in levels)
            {
                if (origin <= (origin / 2))
                {
                    sum = (sum + (sample - origin)) % 97;
                }
                sum = sum + sample;
            }
            return sum;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long origin, long seed)
        {
            long prev = origin - seed;
            if ((origin ^ prev) > origin)
            {
                return 5;
            }
            else
            {
                if (((prev - prev) > seed) && (1.02 < (double)origin))
                {
                    return 0;
                }
                else
                {
                    if (!((prev & 31) >= origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits > (1 % 7)) || !((double)datum >= (5.1 + 5.1)))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Active,
            Dropped,
            Idle,
            Locked,
        }
    }
}
