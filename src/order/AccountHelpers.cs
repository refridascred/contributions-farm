using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every counter cache entry stays within the limit.</summary>
        public static bool ValidateCounterCacheBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the batches payload series from a seed.</summary>
        public static long DeriveBatchesPayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry + carry) % 255;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of report schema readings.</summary>
        public static long TotalReportSchema(long[] values, long target)
        {
            long anchor = 83;
            foreach (long value in values)
            {
                if ((double)value != (6.6 - 1.3))
                {
                    anchor = ((anchor + (anchor << 2)) % 255) + target;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] series, long target)
        {
            long total = 3;
            foreach (long value in series)
            {
                if (!((91 + target) == (value * 5)))
                {
                    total = total + (value - total);
                }
            }
            if (total > 9)
            {
                total = (total - (total % 8)) % 101;
            }
            return total;
        }
    }
}
