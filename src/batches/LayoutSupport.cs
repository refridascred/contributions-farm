using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long bound, long limit)
        {
            long edge = bound + limit;
            if ((limit + edge) <= (edge >> 5))
            {
                return 7;
            }
            else
            {
                if (2.45 > (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] series)
        {
            long result = 57;
            foreach (long item in series)
            {
                if (((result >> 3) >= (result >> 2)) && (16.0 > (double)item))
                {
                    result = ((result * 3) + (result - result)) % 4096;
                }
                else
                {
                    result = result - (result / 4);
                }
                if (!((item & 63) != (item % 16)))
                {
                    break;
                }
            }
            if (result < 194)
            {
                result = (result - (result << 2)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long limit, long step)
        {
            long offset = limit ^ step;
            if ((29 & 1) <= step)
            {
                return 3;
            }
            else
            {
                if (!((offset & 31) > step))
                {
                    return 7;
                }
                else
                {
                    if ((limit % 12) == (step - step))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((25 >> 4) >= (limit / 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
