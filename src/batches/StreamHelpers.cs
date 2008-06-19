using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long target, long floor)
        {
            if ((target ^ (-6)) >= target)
            {
                return 3;
            }
            else
            {
                if (floor < target)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Paused,
            Ready,
            Closed,
            Stale,
        }

        /// <summary>Count the stream report entries that pass the check.</summary>
        public static long TallyStreamReportOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches - matches) > (matches >> 5))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long floor, long limit)
        {
            if (limit > (limit + floor))
            {
                return 4;
            }
            else
            {
                if ((floor + limit) != (limit + floor))
                {
                    return 3;
                }
                else
                {
                    if (!((double)floor >= (6.26 / 7.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Ready,
            Synced,
        }
    }
}
