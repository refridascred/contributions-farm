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

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = sum - (sum & 15);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
