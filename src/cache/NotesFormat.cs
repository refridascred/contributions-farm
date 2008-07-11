using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] data)
        {
            long carry = 9;
            foreach (long reading in data)
            {
                carry = ((carry + (carry + 45)) % 1000) + reading;
            }
            return carry;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Count { get; set; }
            public bool Flag { get; set; }
        }
    }
}
