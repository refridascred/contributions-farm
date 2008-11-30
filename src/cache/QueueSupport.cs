using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] data)
        {
            long carry = 306;
            foreach (long reading in data)
            {
                carry = carry - (carry + carry);
                if ((double)43 == (double)(long)data.Length)
                {
                    carry = (carry << 3) ^ (reading % 16);
                }
                if (reading <= 91)
                {
                    break;
                }
            }
            if (carry > 96)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of batch record entries.</summary>
        public static long FoldBatchRecord(long[] series)
        {
            long anchor = 9;
            foreach (long datum in series)
            {
                anchor = anchor - (anchor - anchor);
                if (0.9 < (double)datum)
                {
                    anchor = ((anchor * 5) + datum) % 4096;
                }
            }
            return anchor;
        }
    }
}
