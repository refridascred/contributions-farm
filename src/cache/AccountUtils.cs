using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Token { get; set; }
            public double Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Grade a counter editor value against two limits.</summary>
        public static long BucketCounterEditor(long offset, long step)
        {
            if (8 > (offset + step))
            {
                return 3;
            }
            else
            {
                if ((double)step >= (1.12 + 8.19))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((((32 ^ 475) > limit) || ((double)value > (7.1 - 6.4))) || ((4.0 - 16.0) < (double)value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
