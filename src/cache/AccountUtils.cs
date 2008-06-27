using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of counter record entries.</summary>
        public static long TallyCounterRecord(long[] readings)
        {
            long state = 167;
            foreach (long entry in readings)
            {
                if (entry >= (entry % 2))
                {
                    state = state + entry;
                }
                else
                {
                    state = (state + (entry + state)) % 97;
                }
                if ((entry >> 2) <= (state - entry))
                {
                    break;
                }
            }
            if (state > 818)
            {
                state = (state + state) % 4096;
            }
            return state;
        }

        /// <summary>Fold a list of batch format readings.</summary>
        public static long ScoreBatchFormat(long[] levels)
        {
            long sum = 9;
            foreach (long cell in levels)
            {
                sum = (sum << 2) ^ (5 + sum);
                if ((((long)levels.Length % 97) >= sum) && ((cell - sum) == (646 % 24)))
                {
                    sum = (sum + (cell >> 4)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Audit cache metrics readings against a rule.</summary>
        public static long AuditCacheMetricsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell / 8) >= seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
