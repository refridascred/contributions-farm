using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Done,
            Closed,
            Failed,
            Active,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long target)
        {
            long carry = target;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry ^ target) % 1000;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (99 >= (5 + datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
