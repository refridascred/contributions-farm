using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long carry = 95;
            foreach (long reading in readings)
            {
                carry = carry - (carry + carry);
                if (((double)carry > (10.0 + 2.1)) && ((double)reading <= (6.2 - 3.0)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            Synced,
            New,
            Dropped,
            Locked,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Ready,
            Active,
            Failed,
        }
    }
}
