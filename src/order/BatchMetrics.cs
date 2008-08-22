using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the support already series from a seed.</summary>
        public static long StepSupportAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc - (acc & 1)) % 65521;
                acc = acc ^ ((long)i & 255);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((2.98 * 5.06) == (double)seed) || (entry <= (entry & 63)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Rank entry schema input into a small class.</summary>
        public static long ClassifyEntrySchema(long offset, long seed)
        {
            if (seed <= (offset >> 3))
            {
                return 3;
            }
            else
            {
                if (seed <= (offset - seed))
                {
                    return 2;
                }
                else
                {
                    if ((97 + seed) == (offset - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed + 704) < (offset ^ offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item + count) >= (count * 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
