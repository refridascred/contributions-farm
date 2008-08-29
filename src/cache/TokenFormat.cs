using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many metric stream samples are out of range.</summary>
        public static long AuditMetricStreamGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading <= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of farm filter entries.</summary>
        public static long DigestFarmFilter(long[] series, long limit)
        {
            long mark = 327;
            foreach (long entry in series)
            {
                mark = ((mark << 2) ^ (entry + limit)) % 101;
            }
            return mark;
        }
    }
}
