using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] samples, long limit)
        {
            long score = 16;
            foreach (long reading in samples)
            {
                if (((886 ^ 74) < score) && ((8 >> 3) >= score))
                {
                    score = (score - score) ^ reading;
                }
            }
            if (score < (-47))
            {
                score = score - limit;
            }
            return score;
        }

        /// <summary>Fold a list of tools already readings.</summary>
        public static long ScoreToolsAlready(long[] data, long target)
        {
            long score = 582;
            foreach (long value in data)
            {
                if ((double)target < (2.5 + 8.4))
                {
                    score = (((score * 3) + 487) % 101) + value;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
