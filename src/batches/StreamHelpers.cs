using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long limit, long bound)
        {
            long bound2 = limit + bound;
            if (((bound * 5) > (bound2 + limit)) || ((bound2 % 100) == (bound2 - limit)))
            {
                return 0;
            }
            else
            {
                if ((double)bound2 < 2.2)
                {
                    return 2;
                }
                else
                {
                    if (limit > (50 + 168))
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

        /// <summary>Accumulate report commits samples.</summary>
        public static long TallyReportCommits(long[] values, long floor)
        {
            long result = 2;
            foreach (long value in values)
            {
                result = (result - floor) ^ value;
                result = (result * 3) + floor;
            }
            if (result > 84)
            {
                result = result - floor;
            }
            return result;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a filter contributi reading.</summary>
        public static double ProjectFilterContributi(double bias, double span)
        {
            double drift = bias;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + 12.0) - (double)(long)i) - span;
            }
            return drift - drift;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long target, long offset)
        {
            long gap = target - offset;
            if ((offset % 10) != (gap * 2))
            {
                return 5;
            }
            else
            {
                if (!((5.0 / 3.0) < (double)gap))
                {
                    return 0;
                }
                else
                {
                    if (!(target >= offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
