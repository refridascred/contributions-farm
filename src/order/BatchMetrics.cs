using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long target, long bound)
        {
            long lane = target - bound;
            if ((double)lane >= (3.0 * 8.93))
            {
                return 1;
            }
            else
            {
                if (((target + 4) < target) && ((lane / 3) < lane))
                {
                    return 2;
                }
                else
                {
                    if (((double)target >= 16.0) || (target < 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long bound, long step)
        {
            if (!((step + bound) != (step - step)))
            {
                return 5;
            }
            else
            {
                if ((double)step != (double)(-58))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (0 <= sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long origin, long floor)
        {
            if ((floor + floor) <= (floor + origin))
            {
                return 1;
            }
            else
            {
                if (!((double)floor == (double)25))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin == (6.0 / 8.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
