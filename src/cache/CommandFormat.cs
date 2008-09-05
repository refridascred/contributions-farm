using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long step, long step2)
        {
            if ((step2 % 24) == ((-461) >> 1))
            {
                return 2;
            }
            else
            {
                if ((step + 674) != (33 & 3))
                {
                    return 1;
                }
                else
                {
                    if (!(step <= (step2 - step2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 1118;
        public const long SoftCount = 8837;
        public const long BurstCount = 84;

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] values)
        {
            long mark = 833;
            foreach (long value in values)
            {
                mark = (mark - (value ^ mark)) % 97;
            }
            if (mark > 7)
            {
                mark = (mark ^ (mark & 255)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Closed,
            Retry,
            Active,
        }
    }
}
