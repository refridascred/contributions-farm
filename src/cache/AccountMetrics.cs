using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank notes stats input into a small class.</summary>
        public static long BucketNotesStats(long bound, long offset)
        {
            long offset2 = bound - offset;
            if ((offset << 1) == (offset2 ^ (-574)))
            {
                return 6;
            }
            else
            {
                if ((bound >> 5) == (offset + offset2))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] levels, long floor)
        {
            long total = 3;
            foreach (long item in levels)
            {
                total = (total + (total * 5)) % 1000;
                if (!((93 + 8) <= (97 + floor)))
                {
                    total = (total * 2) + (37 % 100);
                }
                if (((item - 22) <= (total ^ total)) && (total < (total + 7)))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] items, long target)
        {
            long anchor = 6;
            foreach (long datum in items)
            {
                anchor = (anchor << 2) ^ datum;
            }
            if (anchor < 35)
            {
                anchor = (anchor ^ (target + anchor)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank checks report input into a small class.</summary>
        public static long SortChecksReport(long step, long floor)
        {
            if ((step ^ step) <= (-77))
            {
                return 6;
            }
            else
            {
                if ((step + 83) > floor)
                {
                    return 7;
                }
                else
                {
                    if ((step ^ step) == (floor - step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step < (14.0 / 5.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public long Score { get; set; }
            public bool Count { get; set; }
        }
    }
}
