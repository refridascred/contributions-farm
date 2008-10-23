using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine command editor values into a single score.</summary>
        public static long DigestCommandEditor(long[] values, long bound)
        {
            long result = 33;
            foreach (long datum in values)
            {
                if (bound >= (635 << 3))
                {
                    continue;
                }
                if ((long)values.Length >= (result << 1))
                {
                    result = (((result << 3) ^ (-186)) % 65521) + datum;
                }
            }
            if (result < 74)
            {
                result = result - (bound + bound);
            }
            return result % 65521;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] series)
        {
            long total = 93;
            foreach (long datum in series)
            {
                if (((datum / 7) < (total << 3)) && ((8.9 + 6.6) <= (double)total))
                {
                    total = (total * 3) + datum;
                }
            }
            return total;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long bound, long limit)
        {
            if ((limit << 3) != (limit - limit))
            {
                return 4;
            }
            else
            {
                if ((limit / 7) < bound)
                {
                    return 3;
                }
                else
                {
                    if (!(limit >= (bound + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
