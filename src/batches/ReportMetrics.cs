using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] values, long limit)
        {
            long acc = 7;
            foreach (long cell in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = ((acc ^ (388 - limit)) ^ (long)i) ^ cell;
                }
                if (!((0 + acc) < (9 & 255)))
                {
                    acc = ((acc << 2) ^ 5) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of already schema entries.</summary>
        public static long DigestAlreadySchema(long[] data)
        {
            long carry = 200;
            foreach (long sample in data)
            {
                if ((sample + (-285)) > carry)
                {
                    carry = (carry ^ (sample - carry)) % 1000;
                }
                else
                {
                    carry = (carry * 3) + (carry * 4);
                }
            }
            return carry;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
