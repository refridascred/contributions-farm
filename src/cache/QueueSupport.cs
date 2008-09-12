using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a profile entry counter forward.</summary>
        public static long DeriveProfileEntry(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                carry = carry + (carry >> 1);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Flag { get; set; }
            public double Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
