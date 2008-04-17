using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowCount = 98.96;
        public const long StepPayload = 5995;
        public const long IdlePayload = 4563;
        public const double LimitPayload = 78.63;
        public const double MinWidth = 13.31;

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Limit { get; set; }
            public double Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Combine stream profile values into a single score.</summary>
        public static long TotalStreamProfile(long[] samples)
        {
            long mark = 2;
            foreach (long cell in samples)
            {
                if ((cell + mark) >= mark)
                {
                    mark = ((mark * 2) + (mark - 27)) % 101;
                }
                else
                {
                    mark = mark - cell;
                }
                if ((mark / 5) > (0 - mark))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
