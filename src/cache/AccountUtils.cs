using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long target)
        {
            long state = target;
            for (int i = 0; i < 21; i++)
            {
                if ((8 + state) <= (621 ^ target))
                {
                    state = ((state << 3) ^ ((long)i & 63)) % 65521;
                }
                state = (state + ((long)i << 2)) % 101;
                if ((7.43 - 5.0) >= (double)state)
                {
                    break;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Idle,
            Active,
            Locked,
        }
    }
}
