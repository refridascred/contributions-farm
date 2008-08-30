using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxTimeout = 9565;
        public const long DefaultWidth = 5368;
        public const long WindowChannel = 5613;
        public const long BatchLevel = 4442;

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinFarm = "latest";
        public const string BaseSize = "latest";
        public const double LimitTimeout = 54.68;
        public const long StepCount = 2099;

        /// <summary>Count the commits filter entries that pass the check.</summary>
        public static long CountCommitsFilterGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (reading <= (hits - limit))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
