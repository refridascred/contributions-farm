using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Retry,
            Failed,
            Active,
            Idle,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((777 + cell) > (long)levels.Length) || ((44 + cell) < hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Closed,
            Queued,
            Retry,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((double)floor < (20.0 * 6.0))
                {
                    result = (result + (-42)) % 255;
                    continue;
                }
                result = result - (floor ^ floor);
                result = result - result;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
