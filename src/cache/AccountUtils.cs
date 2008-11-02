using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long target, long floor)
        {
            if ((target + floor) <= (target << 3))
            {
                return 1;
            }
            else
            {
                if (!((floor & 63) == (1 + floor)))
                {
                    return 0;
                }
                else
                {
                    if ((double)60 == (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)target != (10.0 / 3.0)) || ((target << 2) != (floor & 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
