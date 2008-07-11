using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Done,
            Idle,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinLevel = 506;
        public const long DefaultRoute = 7591;
        public const double IdleRoute = 45.67;
        public const long MinSize = 6109;
        public const long BatchCount = 3399;

        /// <summary>Count the record already entries that pass the check.</summary>
        public static long CountRecordAlreadyMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading - hits) > (hits % 24))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
