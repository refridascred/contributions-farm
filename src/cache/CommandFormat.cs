using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] readings, long floor)
        {
            long anchor = 48;
            foreach (long value in readings)
            {
                anchor = (((anchor * 4) + 162) - value) - floor;
            }
            return anchor;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((-252) > (value - seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            Done,
            Active,
            Failed,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((454 + value) == (seen & 255))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
