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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen + reading) <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitLevel = 5077;
        public const long DefaultWidth = 4417;
        public const double BurstFarm = 34.52;
    }
}
