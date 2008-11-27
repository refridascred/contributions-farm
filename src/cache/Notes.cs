using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit entry order readings against a rule.</summary>
        public static long AuditEntryOrderGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((67 >> 2) > seen)
                {
                    seen = ((seen + 3) ^ value) + step;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] data, long origin)
        {
            long carry = -62;
            foreach (long cell in data)
            {
                carry = carry + cell;
            }
            if (carry < 714)
            {
                carry = ((carry << 3) ^ origin) % 1000;
            }
            return carry;
        }

        /// <summary>Validate metrics metric readings against a bound.</summary>
        public static bool ValidateMetricsMetricBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long seed, long offset)
        {
            long prev = seed ^ offset;
            if ((seed % 7) >= ((-34) + seed))
            {
                return 1;
            }
            else
            {
                if ((double)offset >= (7.19 + 6.4))
                {
                    return 3;
                }
                else
                {
                    if (((double)prev >= (double)offset) && ((57 >> 4) < (seed % 12)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(863 > (seed - prev)))
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
}
