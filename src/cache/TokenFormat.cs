using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the commits notes entries that pass the check.</summary>
        public static long CountCommitsNotesHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!(((0.5 * 2.22) < (double)count) && ((395 + count) > (step / 2))))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitRatio = 1539;
        public const double LimitTimeout = 45.41;
        public const long BurstAlready = 4383;
        public const double BatchLevel = 0.83;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
