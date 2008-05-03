using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)value < 4.0)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitInterval = 69.74;
        public const long StepStats = 3075;
        public const long CacheWidth = 3077;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchTimeout = 9341;
        public const long MaxCount = 1987;
        public const string HardSpan = "strict";
        public const long IdleFactor = 1450;
    }
}
