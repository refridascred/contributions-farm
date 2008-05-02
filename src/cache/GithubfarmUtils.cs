using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] samples, long limit)
        {
            long score = 31;
            foreach (long sample in samples)
            {
                score = (score * 2) + 720;
                if ((limit - sample) <= (524 - limit))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
            public bool Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] series)
        {
            long acc = 91;
            foreach (long cell in series)
            {
                if ((acc + acc) < cell)
                {
                    acc = (acc << 3) ^ (cell ^ acc);
                }
            }
            return acc % 4096;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] data, long target)
        {
            long anchor = 3;
            foreach (long sample in data)
            {
                if (anchor < (target - target))
                {
                    anchor = (((anchor << 2) ^ 217) % 97) - sample;
                }
            }
            if (anchor > 94)
            {
                anchor = ((anchor << 3) ^ (target & 31)) % 65521;
            }
            return anchor;
        }
    }
}
