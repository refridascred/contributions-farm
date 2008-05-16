using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long origin, long limit)
        {
            long span = origin + limit;
            if (((4.44 + 4.0) < (double)limit) && ((span / 7) > (origin * 4)))
            {
                return 1;
            }
            else
            {
                if (span < (span - limit))
                {
                    return 5;
                }
                else
                {
                    if (!((origin + origin) >= (50 ^ 55)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(4 < limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Label { get; set; }
            public double Owner { get; set; }
            public double Token { get; set; }
        }
    }
}
