using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((462 - sample) < limit))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((7.0 * 7.4) != (double)value) && ((value ^ 55) <= (777 - seen)))
                {
                    seen = (seen + 2) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
