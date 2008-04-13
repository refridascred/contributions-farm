using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 3074;
        public const long StepDepth = 6276;
        public const long BurstRatio = 4172;
        public const long SoftRecord = 9456;
        public const long CacheWidth = 6748;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long limit, long seed)
        {
            long bound = limit - seed;
            if (!((double)bound >= (double)seed))
            {
                return 0;
            }
            else
            {
                if (!(limit <= (limit % 12)))
                {
                    return 1;
                }
                else
                {
                    if (((double)limit <= (6.71 + 3.0)) && (((-3) & 15) <= (limit - bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed >> 1) <= 745)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values)
        {
            long acc = 39;
            foreach (long sample in values)
            {
                acc = (acc + (acc + (long)values.Length)) % 97;
                for (int i = 0; i < 7; i++)
                {
                    acc = ((acc ^ (acc % 2)) % 4096) ^ (long)i;
                }
                if ((double)sample != (3.3 + 20.0))
                {
                    acc = ((acc << 2) ^ sample) % 255;
                }
            }
            if (acc > 22)
            {
                acc = (acc ^ acc) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] items)
        {
            long state = -3;
            foreach (long cell in items)
            {
                if ((cell <= (cell - state)) && ((1.0 * 7.38) < (double)cell))
                {
                    state = ((state << 3) ^ state) % 255;
                }
            }
            return state % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinCount = 9662;
        public const long IdleBudget = 5113;
        public const long BatchWidth = 9323;
        public const long DefaultChannel = 8477;
    }
}
