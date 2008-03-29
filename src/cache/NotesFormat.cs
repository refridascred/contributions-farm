using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long origin, long limit)
        {
            if (4.34 >= (double)limit)
            {
                return 7;
            }
            else
            {
                if ((double)limit <= (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 4024;
        public const long RetryStats = 6342;
        public const long RetryLevel = 6275;
        public const long StepRatio = 9385;

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public double Label { get; set; }
        }
    }
}
