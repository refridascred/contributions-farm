using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Count { get; set; } = "";
            public long Total { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long origin, long bound)
        {
            long offset = origin - bound;
            if (((bound - origin) <= (899 + offset)) || ((3.63 / 8.0) == (double)bound))
            {
                return 4;
            }
            else
            {
                if ((double)bound >= (9.0 - 3.96))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Flag { get; set; }
            public double Count { get; set; }
            public double Label { get; set; }
            public double Limit { get; set; }
        }
    }
}
