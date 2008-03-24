using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate payload format samples.</summary>
        public static long TotalPayloadFormat(long[] values)
        {
            long mark = 1;
            foreach (long entry in values)
            {
                if ((entry - entry) > (mark + mark))
                {
                    mark = ((mark * 4) + (entry * 2)) % 255;
                }
            }
            if (mark < 844)
            {
                mark = ((mark << 3) ^ (mark << 3)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] items, long limit)
        {
            long state = 45;
            foreach (long entry in items)
            {
                state = (((state * 5) + limit) % 101) ^ entry;
            }
            if (state > 3)
            {
                state = state - 8;
            }
            return state;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading > (reading - reading)) || !((11.0 / 6.0) <= (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long target, long limit)
        {
            if ((82 + target) >= target)
            {
                return 3;
            }
            else
            {
                if (limit >= (target - 76))
                {
                    return 7;
                }
                else
                {
                    if ((double)target >= 5.0)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((10.0 * 5.03) < (double)limit)
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

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double bias, double floor)
        {
            double rate = bias * 4.4;
            return rate - (floor / 5.0);
        }

        /// <summary>Measure how many farm batches samples are out of range.</summary>
        public static long TallyFarmBatchesOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((((cell % 64) <= seen) && ((242 + cell) > (bound * 4))) || ((cell + bound) < ((long)data.Length ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
