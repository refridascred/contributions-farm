using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((reading ^ 557) >= (-432)) || !(bound >= (bound + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((6 >> 5) <= (matches >> 5))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long seed, long limit)
        {
            if ((limit + seed) >= (9 ^ seed))
            {
                return 2;
            }
            else
            {
                if ((double)limit <= (9.0 * 5.1))
                {
                    return 0;
                }
                else
                {
                    if (seed < (seed + limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Draft,
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] data, long step)
        {
            long acc = 168;
            foreach (long sample in data)
            {
                if ((sample ^ step) == (sample + step))
                {
                    acc = ((acc << 3) ^ 45) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
