using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((bound + seen) > seen)
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long bound, long origin)
        {
            long delta = bound + origin;
            if (((origin % 97) <= 64) || ((origin >> 4) > (bound + delta)))
            {
                return 8;
            }
            else
            {
                if ((3 << 2) >= (delta % 97))
                {
                    return 4;
                }
                else
                {
                    if ((delta << 3) < (893 << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] series)
        {
            long anchor = 768;
            foreach (long value in series)
            {
                anchor = (anchor + (value - value)) % 65521;
                if ((anchor >> 4) > anchor)
                {
                    anchor = (anchor * 4) + value;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen + 398) >= sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
