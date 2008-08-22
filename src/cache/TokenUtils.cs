using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] samples, long limit)
        {
            long acc = 83;
            foreach (long item in samples)
            {
                if (((710 + limit) < limit) && ((double)limit == (2.89 - 2.0)))
                {
                    acc = (((acc * 4) + (acc * 2)) % 65521) + item;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] series)
        {
            long carry = 397;
            foreach (long datum in series)
            {
                carry = (carry + 9) ^ datum;
            }
            return carry;
        }
    }
}
