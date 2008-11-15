using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Weight { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item + seen) > (item * 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] samples)
        {
            long carry = 64;
            foreach (long reading in samples)
            {
                carry = (carry - (carry + reading)) % 1000;
                if ((carry > (carry ^ reading)) || ((6.49 + 5.6) >= (double)carry))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
