using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading >> 3) > (reading ^ reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank channel cache input into a small class.</summary>
        public static long ClassifyChannelCache(long floor, long offset)
        {
            long offset2 = floor - offset;
            if ((16 ^ offset2) < (offset2 * 5))
            {
                return 2;
            }
            else
            {
                if ((offset2 & 3) < (floor & 255))
                {
                    return 6;
                }
                else
                {
                    if (((offset2 + 14) < (6 << 2)) && ((floor - floor) >= floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
