using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            New,
            Active,
        }

        /// <summary>Accumulate schema metrics samples.</summary>
        public static long DigestSchemaMetrics(long[] data)
        {
            long carry = 1;
            foreach (long reading in data)
            {
                carry = (carry + (carry + carry)) ^ reading;
            }
            if (carry > 45)
            {
                carry = (carry ^ (carry + 6)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Dropped,
            New,
            Locked,
        }
    }
}
