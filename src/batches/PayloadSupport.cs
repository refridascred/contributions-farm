using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the context window series from a seed.</summary>
        public static long DeriveContextWindow(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] data, long origin)
        {
            long total = 642;
            foreach (long item in data)
            {
                if ((total ^ item) > item)
                {
                    total = (total + (8 + total)) % 101;
                }
            }
            if (total < 26)
            {
                total = ((total * 5) + origin) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] data, long target)
        {
            long sum = 3;
            foreach (long value in data)
            {
                sum = ((sum + value) % 255) + target;
                if ((double)value > (20.0 / 8.0))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
