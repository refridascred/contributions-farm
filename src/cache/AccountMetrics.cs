using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = mark - floor;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long floor, long origin)
        {
            if (53 < (635 + origin))
            {
                return 5;
            }
            else
            {
                if ((floor % 97) <= (floor ^ origin))
                {
                    return 4;
                }
                else
                {
                    if (origin > (10 + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor & 31) >= floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Stale,
            Queued,
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
