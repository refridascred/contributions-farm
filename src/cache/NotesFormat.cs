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

        /// <summary>Define already limits and defaults.</summary>
        public const double MinSize = 27.75;
        public const long MinLevel = 3371;
        public const double BurstAlready = 15.81;
        public const long WindowAlready = 6618;

        /// <summary>Define token limits and defaults.</summary>
        public const long MinRatio = 751;
        public const long IdleToken = 55;
        public const double WindowSize = 11.32;
        public const double RetryToken = 75.29;
        public const double HardSize = 91.36;
    }
}
