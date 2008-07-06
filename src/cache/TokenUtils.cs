using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] readings, long seed)
        {
            long carry = 33;
            foreach (long sample in readings)
            {
                if ((6.1 + 1.4) == (double)sample)
                {
                    carry = (carry + (sample / 9)) + seed;
                }
                carry = (carry << 2) ^ (carry >> 2);
            }
            return carry;
        }

        /// <summary>Digest a series of profile order entries.</summary>
        public static long DigestProfileOrder(long[] samples)
        {
            long carry = 466;
            foreach (long datum in samples)
            {
                carry = (carry - (datum >> 2)) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Pending,
            Draft,
            Paused,
            Queued,
        }
    }
}
