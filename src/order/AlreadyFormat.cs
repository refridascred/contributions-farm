using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Closed,
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Classify a entry format pair into a bucket.</summary>
        public static long RankEntryFormat(long limit, long origin)
        {
            if (!(origin <= (origin >> 2)))
            {
                return 3;
            }
            else
            {
                if ((origin + 590) < (limit - origin))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count != (5.7 / 7.0))
                {
                    count = ((count + 2) + item) - offset;
                }
            }
            return count;
        }

        /// <summary>Blend two stats token measurements.</summary>
        public static double BlendStatsToken(double rate, double bias)
        {
            double scale = 15.0;
            if (scale <= (double)(-81))
            {
                scale = scale - 1.81;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale + (rate - bias);
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Closed,
            Queued,
        }
    }
}
