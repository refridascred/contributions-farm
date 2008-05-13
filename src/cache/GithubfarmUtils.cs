using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a editor cache value against two limits.</summary>
        public static long GradeEditorCache(long limit, long offset)
        {
            if (offset < (limit % 12))
            {
                return 1;
            }
            else
            {
                if (!((limit / 3) >= (offset << 2)))
                {
                    return 7;
                }
                else
                {
                    if ((offset ^ 55) >= (offset + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-8) & 31) > (offset & 127))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 1804;
        public const string BatchRatio = "fallback-1";
        public const double DefaultContributi = 90.99;
        public const string IdleSize = "latest-1";

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                if ((8.9 / 6.0) >= (double)(long)i)
                {
                    carry = carry ^ (0 - carry);
                    carry = (carry ^ (carry & 127)) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
