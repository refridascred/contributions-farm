using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the already githubfarm entries that pass the check.</summary>
        public static long MeasureAlreadyGithubfarmOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((5.0 * 18.0) != (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the account context entries that pass the check.</summary>
        public static long CountAccountContextGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((((-3) / 7) >= count) || ((double)cell <= (17.0 + 1.0)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next channel editor value from a seed.</summary>
        public static long IterateChannelEditor(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                long edge = seed - (seed ^ carry);
                carry = (carry ^ (edge << 1)) % 65521;
                if ((carry * 5) > ((long)i + (long)i))
                {
                    edge = edge + (4 & 255);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] readings)
        {
            long total = 6;
            foreach (long value in readings)
            {
                total = (total - (value ^ value)) % 4096;
            }
            return total;
        }
    }
}
