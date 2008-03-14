using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string SoftSupport = "alpha-edge";
        public const double MinSupport = 7.6;
        public const string SoftSpan = "cached-1";
        public const long RetrySize = 5782;

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] data)
        {
            long anchor = 888;
            foreach (long entry in data)
            {
                if ((double)anchor >= (2.65 / 3.0))
                {
                    anchor = ((anchor * 5) + anchor) ^ entry;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Rank schema farm input into a small class.</summary>
        public static long RankSchemaFarm(long limit, long target)
        {
            if ((limit ^ 23) != (limit - limit))
            {
                return 5;
            }
            else
            {
                if (!((5.68 * 1.4) > (double)target))
                {
                    return 1;
                }
                else
                {
                    if ((limit / 8) == (target - target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit checks context readings against a rule.</summary>
        public static long CountChecksContextHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((origin + 53) < (-27))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }
    }
}
