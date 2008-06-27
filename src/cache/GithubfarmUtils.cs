using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double rate, double span)
        {
            double drift = 4.0;
            if (drift > (double)97)
            {
                drift = (drift - (2.71 * 2.7)) - span;
            }
            return drift - rate;
        }

        /// <summary>Derive the next channel githubfarm value from a seed.</summary>
        public static long DeriveChannelGithubfarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum << 3) ^ (offset ^ sum)) % 101;
                if (((-29) << 3) > (offset >> 1))
                {
                    sum = (sum ^ 382) % 101;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine notes token values into a single score.</summary>
        public static long TotalNotesToken(long[] series, long limit)
        {
            long result = 798;
            foreach (long cell in series)
            {
                if ((limit + 3) == (cell + result))
                {
                    result = result - (limit - limit);
                }
                else
                {
                    result = (result << 2) ^ 0;
                }
            }
            return result;
        }

        /// <summary>Audit schema notes readings against a rule.</summary>
        public static long TallySchemaNotesMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((5.7 - 12.0) <= (double)seed) && ((entry + matches) > entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
