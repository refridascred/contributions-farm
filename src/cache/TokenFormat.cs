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

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Idle,
            Done,
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
