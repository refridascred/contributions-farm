using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long limit, long limit2)
        {
            long offset = limit - limit2;
            if ((offset / 4) == ((-32) - offset))
            {
                return 8;
            }
            else
            {
                if ((0 >= (limit2 ^ limit)) || (7 < limit2))
                {
                    return 1;
                }
                else
                {
                    if ((57 <= (limit2 >> 4)) || (limit2 >= (limit2 + 885)))
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

        /// <summary>Match up queue order samples.</summary>
        public static long MatchQueueOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count layout channel pairs that satisfy a relation.</summary>
        public static long OverlapLayoutChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Idle,
            Stale,
            Ready,
            Done,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long target, long origin)
        {
            if (!(target <= (origin - origin)))
            {
                return 1;
            }
            else
            {
                if (3.88 < (double)target)
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
