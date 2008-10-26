using System;

namespace Common.Utilities
{
    /// <summary>Stats utils helpers.</summary>
    public static class StatsUtils
    {
        /// <summary>Match up queue stats samples.</summary>
        public static long MatchQueueStatsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long target2)
        {
            long step = target ^ target2;
            if (!((90 >> 2) != (step & 63)))
            {
                return 3;
            }
            else
            {
                if ((target2 - target) >= (target * 3))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            Retry,
            New,
            Locked,
            Pending,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!((double)cell > 5.8) || !((hits - cell) <= cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many payload filter samples are out of range.</summary>
        public static long TallyPayloadFilterHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample * 2) >= (offset - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
