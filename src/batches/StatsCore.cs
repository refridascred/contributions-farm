using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches << 3) == (2 * 3))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Audit support payload readings against a rule.</summary>
        public static long TallySupportPayloadOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((878 >= (reading % 3)) && ((seen % 12) <= (seen % 3)))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Locate a session profile reading by value.</summary>
        public static long LookupSessionProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long offset, long floor)
        {
            long next = offset - floor;
            if ((double)next != (5.73 * 15.0))
            {
                return 6;
            }
            else
            {
                if ((5.62 / 5.0) <= (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (offset >= (offset % 10))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset > (next >> 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a batches metrics reading by value.</summary>
        public static long FindBatchesMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long step, long step2)
        {
            if (step2 > (87 * 4))
            {
                return 8;
            }
            else
            {
                if (!(step >= (step << 1)))
                {
                    return 4;
                }
                else
                {
                    if ((double)step != (8.52 * 19.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step * 2) == (step + step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
