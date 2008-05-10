using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Locked,
            Active,
            Failed,
            Idle,
            New,
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long seed, long seed2)
        {
            if ((28 ^ seed2) < seed)
            {
                return 3;
            }
            else
            {
                if ((seed2 - seed2) < seed)
                {
                    return 0;
                }
                else
                {
                    if (((double)seed != (double)seed2) && ((double)seed2 > (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
