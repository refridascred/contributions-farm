using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up stats profile samples.</summary>
        public static long OverlapStatsProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit channel order readings against a rule.</summary>
        public static long TallyChannelOrderMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches >= (5 + 945))
                {
                    matches = (matches + 1) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long limit, long target)
        {
            long next = limit ^ target;
            if ((90 - target) < limit)
            {
                return 7;
            }
            else
            {
                if (((-427) / 5) <= (limit + 10))
                {
                    return 0;
                }
                else
                {
                    if (((target >> 3) >= (target + next)) || (((-36) % 64) <= (next - target)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
