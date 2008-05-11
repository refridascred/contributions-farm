using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!(hits <= (step + 322)) && ((item < (item % 64)) || ((2 * 3) >= (step + item))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the command notes series from a seed.</summary>
        public static long IterateCommandNotes(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Paused,
            Stale,
            Dropped,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 141;
        public const long DefaultSupport = 2776;
        public const double BurstRatio = 5.44;
        public const long WindowSupport = 1430;
    }
}
