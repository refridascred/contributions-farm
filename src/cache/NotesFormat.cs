using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next stream notes value from a seed.</summary>
        public static long StepStreamNotes(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((sum - sum) != (47 & 63))
                {
                    sum = sum + (long)i;
                }
                else
                {
                    sum = (sum << 3) ^ (3 >> 1);
                    sum = (sum ^ (821 >> 3)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Locked,
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 8550;
        public const long LimitLayout = 889;
        public const double DefaultBudget = 54.08;
        public const long DefaultLayout = 9776;
    }
}
