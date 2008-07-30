using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Closed,
            Pending,
            Draft,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            New,
            Active,
            Paused,
            Closed,
        }
    }
}
