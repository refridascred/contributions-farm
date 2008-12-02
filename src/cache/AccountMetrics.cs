using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((limit >= (4 * 5)) || ((step ^ (-19)) == (limit * 2)))
            {
                return 0;
            }
            else
            {
                if ((limit < step) || ((step << 2) > (limit % 5)))
                {
                    return 3;
                }
                else
                {
                    if ((bound < (bound + step)) || ((step % 24) > limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit + step) == (985 ^ limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((2.6 - 1.0) < (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first editor schema entry that matches the target.</summary>
        public static long LookupEditorSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch queue values into a single score.</summary>
        public static long ScoreBatchQueue(long[] values, long offset)
        {
            long total = 42;
            foreach (long item in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = (((((total << 3) ^ 12) % 255) ^ (long)i) - item) - offset;
                }
                total = (total * 5) + 4;
            }
            if (total > 706)
            {
                total = total - (82 << 3);
            }
            return total;
        }

        /// <summary>Audit context filter readings against a rule.</summary>
        public static long MeasureContextFilterHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((12.0 >= (double)seen) && (seen < (1 - (long)items.Length))) || ((seen * 2) > (cell * 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long origin, long target)
        {
            if (origin >= (target - origin))
            {
                return 1;
            }
            else
            {
                if (((double)origin != (4.66 - 1.1)) || ((target % 24) >= origin))
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
}
