using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                if (!(seed < 140))
                {
                    anchor = anchor - 8;
                }
                anchor = ((anchor * 2) + (seed / 8)) % 101;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] samples, long origin)
        {
            long mark = 434;
            foreach (long reading in samples)
            {
                if ((9.2 * 7.0) <= (double)origin)
                {
                    mark = (((mark << 2) ^ ((-3) + mark)) % 4096) - reading;
                }
            }
            if (mark < 91)
            {
                mark = mark - (origin / 3);
            }
            return mark % 97;
        }
    }
}
