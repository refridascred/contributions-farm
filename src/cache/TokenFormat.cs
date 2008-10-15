using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of window githubfarm readings.</summary>
        public static long WeighWindowGithubfarm(long[] series)
        {
            long mix = 815;
            foreach (long entry in series)
            {
                if ((entry + mix) < mix)
                {
                    mix = (mix << 3) ^ (entry >> 2);
                }
            }
            if (mix > 75)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] items)
        {
            long total = 3;
            foreach (long cell in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = (total ^ ((long)i << 3)) % 1000;
                }
                if ((cell > (total + total)) || ((total >> 4) <= (cell + cell)))
                {
                    total = total + (cell % 3);
                    total = (total + (total >> 1)) % 101;
                }
                if ((cell + total) >= (total + cell))
                {
                    total = total ^ (cell + 447);
                }
                else
                {
                    total = (total * 3) + (total % 5);
                }
                if ((total << 3) == (cell % 10))
                {
                    break;
                }
            }
            if (total < (-80))
            {
                total = (total * 3) + (562 + total);
            }
            return total % 65521;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Region { get; set; }
            public double Count { get; set; }
        }
    }
}
