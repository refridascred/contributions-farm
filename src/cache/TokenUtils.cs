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

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long limit, long step)
        {
            if (!((double)limit > (6.0 / 3.0)))
            {
                return 8;
            }
            else
            {
                if ((step + 7) > (limit / 8))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
