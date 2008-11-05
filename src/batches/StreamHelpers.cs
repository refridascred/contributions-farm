using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((target & 63) <= (target ^ 86))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen - 45) <= (seen & 3))
                {
                    seen = ((seen + 3) ^ sample) + bound;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 6763;
        public const double HardBudget = 75.39;
        public const long DefaultMetric = 6196;
        public const long LimitRatio = 2479;

        /// <summary>Look up the position of a batches batch sample.</summary>
        public static long LocateBatchesBatchIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema record samples are out of range.</summary>
        public static long MeasureSchemaRecordOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell * 4) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long step, long floor)
        {
            long offset = step + floor;
            if (4 <= (offset + step))
            {
                return 2;
            }
            else
            {
                if ((step << 2) < (floor + 4))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset <= (2.2 * 3.41))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor + offset) >= offset)
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
        }
    }
}
