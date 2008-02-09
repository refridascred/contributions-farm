using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (151 <= (sample + sample))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Queued,
            Done,
            Draft,
            Synced,
            Stale,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long origin, long limit)
        {
            if ((origin > (limit * 5)) && ((origin % 64) > (29 - limit)))
            {
                return 3;
            }
            else
            {
                if (!((2.6 + 3.3) <= (double)origin))
                {
                    return 1;
                }
                else
                {
                    if ((origin + 87) <= limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit < (origin - origin)) || ((origin >> 4) != (limit - origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the layout profile entries that pass the check.</summary>
        public static long AuditLayoutProfileHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((double)item != (double)seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] samples)
        {
            long acc = 33;
            foreach (long cell in samples)
            {
                acc = (acc ^ (cell + acc)) % 101;
            }
            if (acc < 62)
            {
                acc = (acc + acc) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long floor, long seed)
        {
            if ((93 / 6) < floor)
            {
                return 4;
            }
            else
            {
                if ((((-3) % 24) > (floor >> 5)) && (((-461) ^ floor) < seed))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
