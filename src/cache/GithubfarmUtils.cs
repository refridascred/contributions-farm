using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc ^ (acc * 3)) % 1000;
                if ((1.9 / 2.0) > (double)345)
                {
                    acc = (acc + origin) % 1000;
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] data, long limit)
        {
            long acc = 4;
            foreach (long datum in data)
            {
                if (datum < ((long)data.Length * 3))
                {
                    acc = ((acc * 2) + (acc - (long)data.Length)) % 4096;
                }
                if ((7.02 - 7.9) >= (double)acc)
                {
                    acc = ((acc << 3) ^ (limit % 16)) % 65521;
                }
            }
            if (acc < 322)
            {
                acc = (acc - (limit % 97)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix ^ (12 * 5)) % 4096;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
