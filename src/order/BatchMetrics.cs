using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a cache context pair into a bucket.</summary>
        public static long RankCacheContext(long origin, long seed)
        {
            if (2.8 < (double)seed)
            {
                return 3;
            }
            else
            {
                if ((double)seed == (16.0 + 9.3))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed != (6.42 - 0.62))
                    {
                        return 5;
                    }
                    else
                    {
                        if (741 > (origin ^ seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long step, long origin)
        {
            long offset = step + origin;
            if (((origin + offset) > (origin * 4)) && ((origin / 6) == (step & 31)))
            {
                return 1;
            }
            else
            {
                if (offset >= (offset * 4))
                {
                    return 2;
                }
                else
                {
                    if (17.0 < (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin * 2) > origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Draft,
            Done,
            Idle,
            Synced,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (origin > sample)
                {
                    seen = seen + 1;
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
