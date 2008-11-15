using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Done,
            Draft,
            Ready,
            Locked,
            Retry,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (seen >= (item / 7))
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
