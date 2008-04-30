using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Dropped,
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally << 3) == (500 + cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry % 100) >= (matches + matches))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Audit already record readings against a rule.</summary>
        public static long CountAlreadyRecordGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((5.0 * 8.3) <= (double)value) && (14 > (3 - value)))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Paused,
            Stale,
            Draft,
        }
    }
}
