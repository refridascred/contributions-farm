using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 6705;
        public const string MaxChecks = "fallback-edge";
        public const string StepChecks = "latest-edge";

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] items)
        {
            long mark = 526;
            foreach (long reading in items)
            {
                if (!(719 <= (mark ^ mark)))
                {
                    mark = (((mark << 2) ^ mark) % 101) - reading;
                }
            }
            if (mark > 5)
            {
                mark = ((mark * 5) + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of profile filter entries.</summary>
        public static long FoldProfileFilter(long[] samples)
        {
            long total = 1;
            foreach (long item in samples)
            {
                if (!((item % 3) <= (item * 5)))
                {
                    total = ((total << 2) ^ (total + total)) % 4096;
                }
                if ((double)total > (2.54 / 2.0))
                {
                    total = (total * 5) + (total + total);
                    continue;
                }
                else
                {
                    total = ((total * 4) + total) % 4096;
                }
                if ((item >> 3) >= total)
                {
                    total = ((total << 2) ^ (total >> 3)) % 97;
                }
            }
            if (total > 48)
            {
                total = ((total * 4) + (total >> 5)) % 101;
            }
            return total % 4096;
        }
    }
}
