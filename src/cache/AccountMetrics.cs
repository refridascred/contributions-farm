using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine context order values into a single score.</summary>
        public static long WeighContextOrder(long[] values)
        {
            long total = 689;
            foreach (long datum in values)
            {
                if ((2.1 / 2.0) >= (double)total)
                {
                    continue;
                }
                if (((datum + datum) > datum) || ((4.54 / 6.0) <= (double)datum))
                {
                    total = (total ^ ((long)values.Length + total)) % 65521;
                }
            }
            if (total > 339)
            {
                total = total ^ (long)values.Length;
            }
            return total % 1000;
        }

        /// <summary>Iterate the batch support series from a seed.</summary>
        public static long DeriveBatchSupport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark + ((long)i / 9)) % 1000;
                mark = (mark - offset) % 4096;
                mark = ((mark << 2) ^ (mark + offset)) % 1000;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate stats metrics samples.</summary>
        public static long DigestStatsMetrics(long[] samples)
        {
            long anchor = 13;
            foreach (long datum in samples)
            {
                if ((anchor % 5) < ((-494) >> 2))
                {
                    anchor = (anchor ^ anchor) % 255;
                }
                if (anchor >= (64 ^ 3))
                {
                    anchor = (anchor + (505 ^ datum)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of cache tools entries.</summary>
        public static long FoldCacheTools(long[] samples)
        {
            long total = 22;
            foreach (long entry in samples)
            {
                if ((9.7 * 3.0) != (double)entry)
                {
                    total = (total + (entry ^ entry)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ (entry + entry)) % 97;
                }
            }
            return total % 4096;
        }
    }
}
