using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultRatio = 9969;
        public const long SoftInterval = 3063;
        public const long WindowSpan = 4643;
        public const long WindowTimeout = 9172;
        public const long HardBatch = 1229;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((origin / 5) != (item >> 1))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                if (((total + total) != ((long)i ^ offset)) || ((double)offset < 5.82))
                {
                    continue;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate report filter readings against a bound.</summary>
        public static bool VerifyReportFilterBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
