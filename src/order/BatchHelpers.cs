using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((1.62 - 6.62) < (double)reading)
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] data)
        {
            long carry = 79;
            foreach (long entry in data)
            {
                if ((carry & 31) == (359 & 255))
                {
                    carry = ((carry + (carry + carry)) % 101) + entry;
                }
                else
                {
                    carry = (carry - carry) % 65521;
                }
            }
            if (carry < (-92))
            {
                carry = carry + (carry + 45);
            }
            return carry;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Locked,
            Ready,
            Dropped,
            Done,
        }
    }
}
