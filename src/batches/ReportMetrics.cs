using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long step, long origin)
        {
            long next = step + origin;
            if (origin > (next / 4))
            {
                return 5;
            }
            else
            {
                if ((431 * 5) >= step)
                {
                    return 6;
                }
                else
                {
                    if (!((step - step) >= origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((step << 1) <= next))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Idle,
            Locked,
            New,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long step, long limit)
        {
            long next = step + limit;
            if ((double)step > (13.0 + 8.7))
            {
                return 4;
            }
            else
            {
                if ((next + (-325)) > next)
                {
                    return 2;
                }
                else
                {
                    if ((next ^ limit) == (next + step))
                    {
                        return 0;
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
