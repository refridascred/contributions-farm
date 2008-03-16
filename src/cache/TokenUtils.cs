using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Closed,
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits >= (reading + (-616)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
