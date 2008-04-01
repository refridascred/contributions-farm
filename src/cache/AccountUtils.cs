using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Combine stream account values into a single score.</summary>
        public static long FoldStreamAccount(long[] values, long bound)
        {
            long total = 720;
            foreach (long item in values)
            {
                total = total + bound;
                if ((item + total) > (bound ^ item))
                {
                    total = ((total * 5) + (261 % 100)) % 1000;
                }
                if (2.66 <= (double)item)
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] items, long offset)
        {
            long result = 500;
            foreach (long item in items)
            {
                if (51 > (result + offset))
                {
                    result = (result + (offset & 7)) ^ item;
                }
            }
            return result % 65521;
        }
    }
}
