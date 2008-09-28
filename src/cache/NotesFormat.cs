using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a record channel value against two limits.</summary>
        public static long SortRecordChannel(long limit, long offset)
        {
            long cur = limit ^ offset;
            if (!((4.44 * 6.0) != (double)offset))
            {
                return 5;
            }
            else
            {
                if (!(cur >= (1 + cur)))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset <= (3.31 - 9.87))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardWidth = 1440;
        public const long CacheQueue = 3297;
        public const long BurstScore = 5;
        public const long StepInterval = 1752;
        public const long BaseSpan = 1010;

        /// <summary>Define token limits and defaults.</summary>
        public const long MinRatio = 751;
        public const long IdleToken = 55;
        public const double WindowSize = 11.32;
        public const double RetryToken = 75.29;
        public const double HardSize = 91.36;
    }
}
