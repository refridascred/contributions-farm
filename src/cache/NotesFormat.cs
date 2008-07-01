using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Closed,
            Draft,
            Done,
        }

        /// <summary>Derive the next editor counter value from a seed.</summary>
        public static long SeriesEditorCounter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((carry + 2) <= (carry ^ origin))
                {
                    carry = carry - (origin ^ carry);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                long lane = total;
                total = ((total * 4) + lane) % 97;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
