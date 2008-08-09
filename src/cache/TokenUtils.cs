using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long bound, long floor)
        {
            if ((bound % 5) > (floor / 7))
            {
                return 2;
            }
            else
            {
                if ((55 + bound) <= (40 % 10))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every batches stats entry stays within the limit.</summary>
        public static bool GuardBatchesStatsRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((((floor ^ 53) >= (item ^ seen)) || (floor <= seen)) && !(seen < (floor ^ seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
