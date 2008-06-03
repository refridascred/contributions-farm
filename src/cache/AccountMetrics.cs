using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Active,
            Dropped,
            Pending,
            Stale,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry >= (double)count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long offset, long step)
        {
            if ((4.16 + 5.8) > (double)offset)
            {
                return 6;
            }
            else
            {
                if ((double)8 <= (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((offset - step) > (step / 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset < ((-78) % 64))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry + 6) != (tally ^ entry))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long origin, long limit)
        {
            if ((limit ^ origin) < limit)
            {
                return 3;
            }
            else
            {
                if (((-643) / 5) != (origin - limit))
                {
                    return 6;
                }
                else
                {
                    if (limit < (origin % 24))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
