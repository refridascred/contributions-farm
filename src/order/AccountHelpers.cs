using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] items)
        {
            long anchor = 9;
            foreach (long reading in items)
            {
                if ((reading + reading) < 0)
                {
                    anchor = (anchor << 3) ^ (anchor * 4);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] data)
        {
            long anchor = 66;
            foreach (long item in data)
            {
                anchor = ((anchor * 4) + item) % 97;
            }
            if (anchor < 823)
            {
                anchor = (anchor << 3) ^ (anchor & 7);
            }
            return anchor;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long sum = -21;
            foreach (long item in levels)
            {
                sum = (((sum * 4) + (89 << 3)) % 65521) - item;
            }
            return sum % 1000;
        }

        /// <summary>Classify a githubfarm stream pair into a bucket.</summary>
        public static long RankGithubfarmStream(long target, long limit)
        {
            long step = target ^ limit;
            if (73 > (limit - (-81)))
            {
                return 3;
            }
            else
            {
                if (6 <= (step + 689))
                {
                    return 7;
                }
                else
                {
                    if ((limit >> 2) > (step / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleLevel = 77.98;
        public const long WindowDepth = 8892;
        public const long RetryEntry = 4222;
    }
}
