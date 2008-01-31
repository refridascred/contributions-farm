using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many githubfarm stats samples are out of range.</summary>
        public static long MeasureGithubfarmStatsMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count >= (count ^ sample)) || (((double)sample < (1.0 - 9.62)) || ((count << 3) <= count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of order batch readings.</summary>
        public static long PairOrderBatchCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] values)
        {
            long acc = 8;
            foreach (long reading in values)
            {
                acc = acc + 30;
                if ((reading & 63) > reading)
                {
                    acc = ((acc << 2) ^ (acc ^ acc)) % 4096;
                }
            }
            return acc;
        }
    }
}
