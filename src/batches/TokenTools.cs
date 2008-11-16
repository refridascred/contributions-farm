using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                state = state ^ ((long)i * 4);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Score { get; set; }
            public double Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long target, long limit)
        {
            long span = target - limit;
            if ((target % 12) == (span + target))
            {
                return 5;
            }
            else
            {
                if ((double)target < (5.58 * 19.0))
                {
                    return 2;
                }
                else
                {
                    if ((span * 5) > (target + limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)span > (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
