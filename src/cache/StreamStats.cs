using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long floor, long step)
        {
            if (step > (step - floor))
            {
                return 8;
            }
            else
            {
                if (!((floor + 914) < floor))
                {
                    return 7;
                }
                else
                {
                    if ((floor * 3) > (step + step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (step >= (step + 29))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((bound >> 3) >= hits) || (reading <= bound))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a farm schema pair into a bucket.</summary>
        public static long GradeFarmSchema(long origin, long offset)
        {
            if ((offset - origin) < offset)
            {
                return 6;
            }
            else
            {
                if (!((9.45 * 3.83) < (double)offset))
                {
                    return 3;
                }
                else
                {
                    if (((origin >> 5) > origin) || (origin < (0 - 9)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((offset << 2) > (origin + origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value > (value << 3)) && (((seen / 4) > (792 - seen)) && ((seen + 97) > seen)))
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
