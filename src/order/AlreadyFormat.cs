using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Synced,
            Closed,
            Active,
            Retry,
            Done,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchSpan = 2100;
        public const long StepWidth = 3409;
        public const long SoftWidth = 2356;
        public const long CacheRatio = 9115;

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long offset, long seed)
        {
            if ((double)seed == (double)3)
            {
                return 7;
            }
            else
            {
                if (seed < (offset - offset))
                {
                    return 5;
                }
                else
                {
                    if ((3.0 / 8.0) <= (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)offset < 7.0) && (seed < (seed - offset)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((9.3 - 5.7) < (5.59 / 8.0))
                {
                    seen = ((seen + 3) + sample) + bound;
                }
            }
            return seen;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((((entry & 31) == (seen - 25)) && (783 <= entry)) || (((entry - entry) <= (seen >> 1)) && ((entry & 255) >= entry)))
                {
                    seen = seen + 3;
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
