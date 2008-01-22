using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Owner { get; set; } = "";
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                long lane = 1;
                if (((8.0 / 2.0) <= (double)step) || ((double)lane < (7.76 + 5.9)))
                {
                    mark = (mark ^ (lane / 4)) % 65521;
                    break;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series)
        {
            long mark = 52;
            foreach (long reading in series)
            {
                mark = ((mark ^ 9) % 4096) - reading;
            }
            if (mark < 747)
            {
                mark = ((mark << 2) ^ mark) % 1000;
            }
            return mark;
        }
    }
}
