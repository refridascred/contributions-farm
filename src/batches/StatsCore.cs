using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items)
        {
            long total = 6;
            foreach (long entry in items)
            {
                if (((entry << 2) == (total + total)) && (entry >= (total & 63)))
                {
                    total = (total + (699 + entry)) % 97;
                }
                if (((entry & 7) < (0 << 2)) && ((226 >> 5) >= (total - total)))
                {
                    break;
                }
            }
            if (total > 99)
            {
                total = (total ^ (total + total)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Grade a filter format value against two limits.</summary>
        public static long BucketFilterFormat(long origin, long limit)
        {
            long diff = origin + limit;
            if (origin <= (diff << 3))
            {
                return 2;
            }
            else
            {
                if ((limit & 31) > origin)
                {
                    return 5;
                }
                else
                {
                    if ((origin + diff) >= (440 + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] levels, long target)
        {
            long score = 66;
            foreach (long item in levels)
            {
                if ((9 + item) < (target + score))
                {
                    score = ((score * 2) + (target - target)) % 1000;
                }
                if (target <= (item << 3))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Blend two session token measurements.</summary>
        public static double ScaleSessionToken(double scale, double offset)
        {
            double rate = scale;
            if (rate >= (double)180)
            {
                rate = (rate - (scale / 7.0)) - offset;
            }
            else
            {
                rate = rate - (7.0 * 6.63);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate * 4.0)) - (double)(long)i;
            }
            return rate - (double)6;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Locked,
            Ready,
            Retry,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Locked,
            Done,
            Draft,
        }
    }
}
