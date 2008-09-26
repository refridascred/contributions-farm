using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry + (11 % 5)) % 255;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Locked,
            Draft,
            Active,
            Ready,
        }
    }
}
