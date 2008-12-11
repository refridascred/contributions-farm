using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Done,
            Queued,
            Locked,
            Ready,
            Synced,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Rank metrics cluster input into a small class.</summary>
        public static long BucketMetricsCluster(long bound, long bound2)
        {
            long lane = bound ^ bound2;
            if ((8.93 - 4.0) != (double)bound)
            {
                return 2;
            }
            else
            {
                if (lane <= (bound + bound2))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long limit, long limit2)
        {
            if (!(((-42) + limit) < (limit % 24)))
            {
                return 8;
            }
            else
            {
                if (limit2 <= (limit2 >> 1))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit2 == (18.0 / 5.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(((origin + origin) >= origin) || ((origin % 8) <= (reading >> 3))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                state = (state * 3) + 4;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
