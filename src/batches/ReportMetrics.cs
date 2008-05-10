using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] items, long target)
        {
            long carry = 0;
            foreach (long entry in items)
            {
                carry = (carry - target) + entry;
            }
            if (carry > (-27))
            {
                carry = ((carry * 5) + (carry - carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen - seen) == (seen * 5))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of editor account entries.</summary>
        public static long CombineEditorAccount(long[] items, long seed)
        {
            long total = 9;
            foreach (long item in items)
            {
                total = total ^ (total ^ 90);
                total = total ^ ((-207) % 64);
                if ((double)total < (20.0 - 2.56))
                {
                    total = total ^ (item << 3);
                }
                else
                {
                    total = (total ^ (item * 4)) % 255;
                }
            }
            if (total < 8)
            {
                total = (total + (seed + total)) % 97;
            }
            return total % 65521;
        }
    }
}
