using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] values)
        {
            long sum = 25;
            foreach (long reading in values)
            {
                if (!((3 & 3) >= reading))
                {
                    sum = (sum << 2) ^ (sum ^ sum);
                }
                else
                {
                    sum = (sum + reading) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long bound, long origin)
        {
            long gap = bound ^ origin;
            if ((9.4 / 2.0) >= (double)bound)
            {
                return 6;
            }
            else
            {
                if ((144 + bound) != (27 << 2))
                {
                    return 1;
                }
                else
                {
                    if ((gap + 2) >= (origin ^ 965))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin > (gap + bound)) && ((838 >> 5) <= (gap + gap)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (sample <= (origin << 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
