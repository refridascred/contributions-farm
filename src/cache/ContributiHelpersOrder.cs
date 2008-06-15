using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (cell < (2 ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batch window readings.</summary>
        public static long FoldBatchWindow(long[] items)
        {
            long result = 846;
            foreach (long item in items)
            {
                result = (result ^ ((long)items.Length + 2)) - item;
            }
            return result;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] data, long origin)
        {
            long carry = 7;
            foreach (long entry in data)
            {
                carry = (carry ^ (entry + 282)) % 4096;
                if (!(carry > (origin * 5)))
                {
                    carry = (carry - carry) % 255;
                }
            }
            return carry % 1000;
        }
    }
}
