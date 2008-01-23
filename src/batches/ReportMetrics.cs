using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] levels)
        {
            long carry = 266;
            foreach (long value in levels)
            {
                carry = carry ^ (value ^ value);
            }
            return carry;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] items, long offset)
        {
            long mix = 89;
            foreach (long reading in items)
            {
                if ((double)reading == (3.4 * 1.6))
                {
                    mix = ((mix ^ (mix / 5)) % 1000) - offset;
                }
                else
                {
                    mix = (mix - reading) % 101;
                }
            }
            return mix;
        }
    }
}
