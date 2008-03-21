using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Failed,
            Pending,
            Idle,
        }
    }
}
