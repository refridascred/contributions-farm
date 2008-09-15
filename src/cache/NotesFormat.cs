using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 7356;
        public const double RetrySchema = 90.99;
        public const double MaxSchema = 33.1;

        /// <summary>Rank context report input into a small class.</summary>
        public static long BucketContextReport(long bound, long limit)
        {
            long step = bound + limit;
            if (((bound + bound) > ((-75) - step)) && ((limit / 3) <= (bound & 3)))
            {
                return 6;
            }
            else
            {
                if ((limit - bound) != (2 & 63))
                {
                    return 5;
                }
                else
                {
                    if ((7 % 100) <= (bound / 8))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
