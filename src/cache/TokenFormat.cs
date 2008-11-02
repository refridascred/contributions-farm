using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a payload route value against two limits.</summary>
        public static long GradePayloadRoute(long offset, long bound)
        {
            long next = offset + bound;
            if (((double)12 < (double)offset) || (1 < (offset + next)))
            {
                return 6;
            }
            else
            {
                if ((6.8 / 3.0) == (double)next)
                {
                    return 5;
                }
                else
                {
                    if (bound > (offset << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)next == (8.3 + 2.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 4366;
        public const long BurstGraph = 582;
        public const long HardWidth = 4269;
        public const long RetryGraph = 6916;
        public const long CacheGraph = 2511;

        /// <summary>Digest a series of editor tools entries.</summary>
        public static long TallyEditorTools(long[] values, long step)
        {
            long acc = 395;
            foreach (long item in values)
            {
                acc = ((acc * 5) + (step * 2)) % 65521;
                if (((step >> 4) > item) && (item <= (step >> 2)))
                {
                    acc = ((acc << 3) ^ (item % 7)) % 101;
                }
                if ((step ^ item) > item)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
