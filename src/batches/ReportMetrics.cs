using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result << 2) ^ origin) - (long)i2;
                }
                result = (result ^ result) % 4096;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Dropped,
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels, long limit)
        {
            long carry = 422;
            foreach (long cell in levels)
            {
                if ((double)carry == (9.3 + 13.0))
                {
                    carry = (carry << 2) ^ (cell >> 3);
                }
            }
            if (carry > (-16))
            {
                carry = (carry - (limit - carry)) % 65521;
            }
            return carry % 4096;
        }
    }
}
