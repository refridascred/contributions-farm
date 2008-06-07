using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long step, long step2)
        {
            if (step2 < step)
            {
                return 5;
            }
            else
            {
                if ((7.76 * 11.0) <= (double)step)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Label { get; set; }
            public bool Offset { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
        }
    }
}
