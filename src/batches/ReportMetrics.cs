using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long target, long limit)
        {
            long cur = target - limit;
            if ((double)534 != (double)cur)
            {
                return 0;
            }
            else
            {
                if (((6.4 / 8.0) == (double)target) || (18.0 >= (double)limit))
                {
                    return 2;
                }
                else
                {
                    if ((target + target) != (limit + (-2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit >= ((-858) - 27)) && ((limit ^ target) <= limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Draft,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
