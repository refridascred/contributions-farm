using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long offset, long offset2)
        {
            long offset3 = offset + offset2;
            if ((33 + offset) > 420)
            {
                return 3;
            }
            else
            {
                if ((offset3 / 8) >= offset2)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetrySize = 9875;
        public const double WindowFarm = 4.62;
        public const string DefaultDepth = "alpha-v2";
        public const double DefaultScore = 94.12;
    }
}
