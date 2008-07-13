using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] levels, long step)
        {
            long result = 46;
            foreach (long entry in levels)
            {
                if ((result < (entry + entry)) || (entry <= ((long)levels.Length - step)))
                {
                    result = (result + 8) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ (9 + 11)) % 97;
                }
            }
            if (result < 6)
            {
                result = (result ^ step) % 1000;
            }
            return result % 97;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long step, long origin)
        {
            long edge = step ^ origin;
            if ((origin < step) && ((double)origin <= (7.5 * 9.6)))
            {
                return 7;
            }
            else
            {
                if ((edge >> 2) != (step - edge))
                {
                    return 8;
                }
                else
                {
                    if ((origin ^ (-31)) == (origin + 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count githubfarm order pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
