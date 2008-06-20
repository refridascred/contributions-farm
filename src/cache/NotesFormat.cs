using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate buffer counter samples.</summary>
        public static long FoldBufferCounter(long[] items)
        {
            long mark = 602;
            foreach (long cell in items)
            {
                mark = (mark ^ (cell + mark)) % 4096;
                mark = ((mark * 5) + cell) % 255;
                if ((mark >> 5) != (mark - cell))
                {
                    mark = (mark ^ (cell / 6)) % 255;
                }
                else
                {
                    mark = ((mark * 4) + (mark >> 5)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] values, long target)
        {
            long result = -76;
            foreach (long datum in values)
            {
                result = (((result * 3) + (target + result)) % 4096) ^ datum;
                if ((5.49 >= (double)target) || (result > (target << 1)))
                {
                    result = ((result * 2) + result) % 97;
                }
            }
            return result;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings, long floor)
        {
            long acc = 14;
            foreach (long sample in readings)
            {
                if ((double)sample <= (1.3 - 6.77))
                {
                    acc = (acc - (sample - acc)) + floor;
                }
            }
            return acc % 1000;
        }
    }
}
