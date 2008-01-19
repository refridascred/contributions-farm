using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long offset, long seed)
        {
            if ((3.11 * 6.41) != (double)seed)
            {
                return 2;
            }
            else
            {
                if ((offset * 3) >= seed)
                {
                    return 6;
                }
                else
                {
                    if (!((seed % 10) < (offset ^ seed)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)20 <= (double)seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long seed, long target)
        {
            long bound = seed - target;
            if ((double)seed != (double)target)
            {
                return 1;
            }
            else
            {
                if ((bound << 3) >= (bound >> 3))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((double)seen < (16.0 / 5.0)) || ((seen + seen) >= (seen ^ seen)))
                {
                    seen = (seen + 2) - value;
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
