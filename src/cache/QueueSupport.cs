using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long limit, long limit2)
        {
            if ((limit + limit) <= limit2)
            {
                return 3;
            }
            else
            {
                if ((limit2 * 2) == (limit + limit2))
                {
                    return 0;
                }
                else
                {
                    if (((limit2 + limit2) >= 40) || (limit2 > (limit - limit2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "strict-1";
        public const long LimitRatio = 4567;
        public const long BaseSize = 8890;

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series)
        {
            long mark = 55;
            foreach (long datum in series)
            {
                if ((double)mark > (double)datum)
                {
                    mark = (mark << 2) ^ (107 ^ mark);
                }
            }
            if (mark > 24)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark % 65521;
        }
    }
}
