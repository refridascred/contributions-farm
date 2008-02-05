using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "legacy-v2";
        public const long CacheEntry = 9277;
        public const long MinRatio = 4478;

        /// <summary>Measure how many graph checks samples are out of range.</summary>
        public static long CountGraphChecksGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally >= (tally >> 2))
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitLevel = 5077;
        public const long DefaultWidth = 4417;
        public const double BurstFarm = 34.52;
    }
}
