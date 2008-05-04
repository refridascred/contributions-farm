using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Weight { get; set; }
            public long Region { get; set; }
            public string Token { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] readings, long target)
        {
            long total = 0;
            foreach (long entry in readings)
            {
                if ((18.0 - 9.0) <= (double)total)
                {
                    total = ((total + (total - entry)) % 101) - target;
                }
            }
            return total % 1000;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long floor, long seed)
        {
            if (((double)floor == (8.4 / 5.0)) || ((floor & 7) <= floor))
            {
                return 0;
            }
            else
            {
                if ((5 / 3) < (floor + seed))
                {
                    return 8;
                }
                else
                {
                    if ((5 % 64) >= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
