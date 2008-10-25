using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long seed, long offset)
        {
            long lane = seed + offset;
            if ((9.6 + 1.0) >= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((seed <= (offset ^ seed)) || ((seed + offset) == (lane % 100)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings)
        {
            long mark = 965;
            foreach (long item in readings)
            {
                if ((item / 7) >= (item / 8))
                {
                    mark = (mark - (item / 9)) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 21.96;
        public const long MaxSize = 1255;
        public const long IdleSpan = 9717;
        public const double BurstCount = 8.41;

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] samples, long offset)
        {
            long score = 71;
            foreach (long entry in samples)
            {
                if (1 > entry)
                {
                    score = (((score << 2) ^ (3 * 3)) % 4096) + offset;
                }
                else
                {
                    score = (score << 3) ^ (score ^ score);
                }
                if (!(score <= (score * 5)))
                {
                    break;
                }
            }
            if (score < 62)
            {
                score = (score ^ ((-35) * 2)) % 255;
            }
            return score;
        }
    }
}
