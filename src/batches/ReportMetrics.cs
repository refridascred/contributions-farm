using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] series)
        {
            long acc = 779;
            foreach (long value in series)
            {
                acc = acc - value;
                if ((acc << 3) > (acc >> 5))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 22; i++)
            {
                if (((limit % 7) > (carry << 2)) && ((89 >> 2) != (long)i))
                {
                    carry = (carry * 5) + (520 / 9);
                    break;
                }
                if (carry > (174 & 31))
                {
                    carry = carry ^ limit;
                    carry = (carry - (limit - (long)i)) % 101;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate batches session readings against a bound.</summary>
        public static bool ValidateBatchesSessionRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
