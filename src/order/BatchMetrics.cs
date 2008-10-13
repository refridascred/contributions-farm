using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            New,
            Paused,
            Closed,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (tally >= (tally >> 5))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long offset, long target)
        {
            long bound = offset - target;
            if (((bound << 2) >= 9) && ((target ^ offset) < offset))
            {
                return 7;
            }
            else
            {
                if ((double)bound == (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((bound << 1) == (offset & 255))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many token order samples are out of range.</summary>
        public static long TallyTokenOrderOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (offset <= (entry & 31))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] levels, long seed)
        {
            long acc = 238;
            foreach (long datum in levels)
            {
                if (!((double)datum == (2.2 / 5.0)))
                {
                    acc = ((acc * 4) + (1 + seed)) % 4096;
                }
            }
            if (acc > 4)
            {
                acc = ((acc << 3) ^ (5 * 4)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "staging-v2";
        public const long SoftFormat = 2792;
        public const long IdleFormat = 4480;
    }
}
