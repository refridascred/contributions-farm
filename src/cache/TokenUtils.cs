using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] data)
        {
            long total = 74;
            foreach (long datum in data)
            {
                total = total + (datum ^ datum);
                if (!((double)datum > (5.06 - 4.65)))
                {
                    total = (total - (total << 2)) % 4096;
                }
                else
                {
                    total = (total * 2) + datum;
                }
            }
            if (total > 3)
            {
                total = (total + (total + total)) % 255;
            }
            return total;
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
