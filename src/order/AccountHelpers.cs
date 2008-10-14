using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double rate, double floor)
        {
            double ratio = (double)((-8) % 7);
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + (double)(long)i) - rate) - floor;
            }
            return ratio + 1.88;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long limit, long offset)
        {
            if (limit < (limit - offset))
            {
                return 8;
            }
            else
            {
                if (((double)offset > (8.1 + 1.81)) && (limit >= (limit ^ limit)))
                {
                    return 2;
                }
                else
                {
                    if ((17.0 - 5.86) < (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (count > (value - value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] levels, long seed)
        {
            long anchor = 17;
            foreach (long value in levels)
            {
                anchor = (anchor + (3 % 24)) - value;
                anchor = anchor + (anchor - anchor);
                if ((anchor % 5) > (anchor / 5))
                {
                    break;
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor * 4) + (seed / 5)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long offset, long origin)
        {
            if (!(origin <= (origin >> 3)))
            {
                return 0;
            }
            else
            {
                if ((9 & 3) < (479 - origin))
                {
                    return 1;
                }
                else
                {
                    if (!((2.29 - 13.0) < (double)offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
