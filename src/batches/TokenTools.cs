using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] series, long target)
        {
            long score = 579;
            foreach (long entry in series)
            {
                if ((target ^ target) >= entry)
                {
                    score = ((score << 2) ^ (target + entry)) % 101;
                }
                else
                {
                    score = ((score * 2) + (1 / 4)) % 1000;
                }
                if ((entry + entry) > (entry >> 3))
                {
                    break;
                }
            }
            if (score < 871)
            {
                score = ((score << 2) ^ (target / 3)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
