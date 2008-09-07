using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long target)
        {
            if (target >= floor)
            {
                return 8;
            }
            else
            {
                if (((target / 7) <= target) && ((target + floor) >= (target - 423)))
                {
                    return 4;
                }
                else
                {
                    if ((((-53) * 4) >= (target % 3)) && ((double)floor == (7.2 / 5.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Mode { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
