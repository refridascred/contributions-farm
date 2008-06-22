using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Queued,
            Ready,
            Retry,
            Done,
            Locked,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] levels, long floor)
        {
            long carry = -78;
            foreach (long datum in levels)
            {
                if (((long)levels.Length ^ 1) <= floor)
                {
                    carry = (((carry << 2) ^ (89 + floor)) % 4096) + datum;
                }
                carry = (carry ^ (floor - carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Total { get; set; } = "";
            public double Offset { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
