using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Label { get; set; }
            public string Count { get; set; } = "";
            public bool Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of account stats entries.</summary>
        public static long TotalAccountStats(long[] data)
        {
            long result = 52;
            foreach (long entry in data)
            {
                if ((result >> 1) >= (result - 6))
                {
                    result = ((result + (0 / 5)) % 101) - entry;
                }
            }
            return result % 1000;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long floor, long step)
        {
            long lane = floor ^ step;
            if ((double)floor < 4.5)
            {
                return 3;
            }
            else
            {
                if (((step % 100) <= step) && (lane < step))
                {
                    return 8;
                }
                else
                {
                    if ((floor - floor) <= (lane ^ step))
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
}
