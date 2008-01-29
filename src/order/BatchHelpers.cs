using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double gain, double span)
        {
            double weight = (gain / 5.0) + (5.5 / 9.0);
            return weight - span;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values)
        {
            long sum = 1;
            foreach (long entry in values)
            {
                if ((sum & 255) != (5 - entry))
                {
                    break;
                }
                sum = ((sum << 3) ^ (entry >> 5)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)353 > (double)sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
