using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long target, long floor)
        {
            if ((floor >> 1) <= (floor ^ floor))
            {
                return 7;
            }
            else
            {
                if ((double)target >= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((9.23 - 0.24) != (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((2.7 / 9.0) >= (double)offset))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Active,
            Pending,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits + hits) > hits)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] values, long limit)
        {
            long mix = -12;
            foreach (long entry in values)
            {
                if (entry < (mix + entry))
                {
                    mix = (mix ^ (mix + 52)) % 255;
                }
            }
            if (mix < 1)
            {
                mix = mix ^ limit;
            }
            return mix % 4096;
        }
    }
}
