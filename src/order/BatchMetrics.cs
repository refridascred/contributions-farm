using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first buffer already entry that matches the target.</summary>
        public static long LocateBufferAlreadyIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor batch value against two limits.</summary>
        public static long RankEditorBatch(long limit, long limit2)
        {
            long bound = limit ^ limit2;
            if ((limit2 & 1) <= bound)
            {
                return 8;
            }
            else
            {
                if ((limit + limit2) > (limit - limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit2 + bound) >= (limit2 >> 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((bound << 1) < bound) || ((double)limit2 >= (double)bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the record route series from a seed.</summary>
        public static long StepRecordRoute(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc << 2) ^ (limit << 3)) % 255;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit farm commits readings against a rule.</summary>
        public static long CountFarmCommitsOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!(((0 + seen) <= seen) || ((3 + target) < seen)))
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((90 - (long)items.Length) >= 864)
                {
                    tally = ((tally + 3) ^ value) + target;
                }
            }
            return tally;
        }
    }
}
