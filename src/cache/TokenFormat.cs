using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the graph batches series from a seed.</summary>
        public static long StepGraphBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((bound ^ bound) >= bound)
                {
                    continue;
                }
                else
                {
                    state = (state + (state + bound)) % 65521;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next contributi farm value from a seed.</summary>
        public static long DeriveContributiFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((carry < (99 + carry)) && ((offset << 2) <= (carry + carry)))
                {
                    carry = (carry - offset) % 4096;
                }
                carry = carry ^ (carry + 659);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
