using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = acc + (acc ^ acc);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Active,
            Retry,
            Idle,
        }

        /// <summary>Derive the next filter metric value from a seed.</summary>
        public static long SeriesFilterMetric(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                if (!((double)floor != (4.0 / 6.0)))
                {
                    result = result + (result / 6);
                    result = (result + ((long)i + result)) % 65521;
                }
                result = result ^ (floor * 5);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
