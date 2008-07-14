using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Ratio { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a order notes value against two limits.</summary>
        public static long RankOrderNotes(long origin, long limit)
        {
            if ((4 <= origin) && ((2.9 / 3.0) < (double)origin))
            {
                return 0;
            }
            else
            {
                if ((limit ^ origin) >= limit)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
