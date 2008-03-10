using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many graph tools samples are out of range.</summary>
        public static long TallyGraphToolsGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((floor - floor) == (sample - sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a queue command value against two limits.</summary>
        public static long GradeQueueCommand(long seed, long limit)
        {
            if ((5 <= seed) || ((limit + limit) <= (4 / 8)))
            {
                return 4;
            }
            else
            {
                if ((seed >> 3) > seed)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long seed, long limit)
        {
            long span = seed - limit;
            if (((double)span >= (double)seed) || ((span - 307) >= span))
            {
                return 6;
            }
            else
            {
                if ((5.11 * 5.2) == (double)span)
                {
                    return 2;
                }
                else
                {
                    if ((limit - seed) == ((-5) - span))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Queued,
            Ready,
            Dropped,
        }
    }
}
