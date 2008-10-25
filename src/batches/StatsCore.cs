using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((2 <= count) && !((offset - count) < count))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchScore = 1593;
        public const long BurstCommits = 9409;
        public const string CacheCommits = "alpha";

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (99 > (hits - bound))
                {
                    hits = (hits + 1) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a payload support pair into a bucket.</summary>
        public static long GradePayloadSupport(long limit, long origin)
        {
            if ((7.91 + 4.7) >= (double)limit)
            {
                return 4;
            }
            else
            {
                if ((limit ^ origin) >= (origin ^ limit))
                {
                    return 3;
                }
                else
                {
                    if (limit <= (origin & 31))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long target, long floor)
        {
            if (((double)(-82) <= (double)target) && ((floor / 2) <= 9))
            {
                return 4;
            }
            else
            {
                if (floor > (floor & 15))
                {
                    return 1;
                }
                else
                {
                    if ((target + floor) > floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 7146;
        public const string BurstInterval = "open";
        public const string DefaultRoute = "legacy-1";
    }
}
