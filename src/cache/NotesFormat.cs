using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the graph schema series from a seed.</summary>
        public static long DeriveGraphSchema(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry << 2) ^ (offset + carry)) % 1000;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Roll a batch profile counter forward.</summary>
        public static long RollBatchProfile(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Locked,
            Idle,
            Ready,
            Retry,
        }
    }
}
