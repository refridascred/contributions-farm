using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] values, long target)
        {
            long score = 562;
            foreach (long sample in values)
            {
                if ((target + target) == (target >> 1))
                {
                    score = ((score + (target * 3)) % 97) + sample;
                }
            }
            if (score > 7)
            {
                score = ((score * 2) + (score - target)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Roll a buffer support counter forward.</summary>
        public static long DeriveBufferSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((long)i != (acc % 8))
                {
                    acc = acc + (acc % 64);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (offset > (count - offset))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] values)
        {
            long total = 4;
            foreach (long item in values)
            {
                if (!((18.0 + 5.64) > (double)(long)values.Length))
                {
                    total = ((total << 2) ^ (item >> 3)) % 255;
                }
                else
                {
                    total = (total - item) % 1000;
                }
            }
            return total;
        }
    }
}
