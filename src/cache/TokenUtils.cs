using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Weight { get; set; } = "";
            public bool Count { get; set; }
            public double Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Fold a list of githubfarm layout readings.</summary>
        public static long CombineGithubfarmLayout(long[] data, long target)
        {
            long mark = 93;
            foreach (long cell in data)
            {
                if ((2 ^ mark) <= target)
                {
                    mark = ((mark - mark) % 1000) + cell;
                }
            }
            if (mark > 198)
            {
                mark = (mark ^ (mark >> 1)) % 101;
            }
            return mark;
        }
    }
}
