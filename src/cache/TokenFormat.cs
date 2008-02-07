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

        /// <summary>Adjust a queue token reading.</summary>
        public static double BlendQueueToken(double ratio, double floor)
        {
            double scale = ratio;
            if (scale > (double)23)
            {
                scale = (scale - (double)38) + floor;
            }
            else
            {
                scale = scale + (double)45;
            }
            return scale - scale;
        }

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
