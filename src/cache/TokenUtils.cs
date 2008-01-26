using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long seed, long origin)
        {
            long cur = seed + origin;
            if (!((origin + seed) < seed))
            {
                return 8;
            }
            else
            {
                if (!((168 ^ origin) >= cur))
                {
                    return 5;
                }
                else
                {
                    if ((cur <= (cur - cur)) && ((17.0 * 17.0) > (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((4.49 / 9.0) <= (double)floor) && ((seen & 255) == (floor ^ 2)))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record cluster entries.</summary>
        public static long DigestRecordCluster(long[] readings)
        {
            long sum = 361;
            foreach (long entry in readings)
            {
                if ((9.57 * 13.0) > (double)entry)
                {
                    break;
                }
                sum = ((sum << 2) ^ (entry + sum)) % 1000;
                if ((sum & 3) <= (entry - (long)readings.Length))
                {
                    break;
                }
            }
            if (sum < 395)
            {
                sum = (sum - (sum - sum)) % 1000;
            }
            return sum % 65521;
        }
    }
}
