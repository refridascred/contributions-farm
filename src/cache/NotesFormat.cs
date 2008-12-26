using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((279 << 1) <= hits)
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 4003;
        public const double LimitFarm = 84.86;
        public const double BaseFarm = 88.07;

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleScore = 1251;
        public const long StepWidth = 1734;
        public const double DefaultRoute = 83.05;
        public const long StepRoute = 9730;
        public const double CacheTimeout = 65.44;
    }
}
