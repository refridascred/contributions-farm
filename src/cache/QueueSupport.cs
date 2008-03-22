using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((((long)i / 2) == (sum << 1)) && ((double)bound < (double)(long)i))
                {
                    long hits = ((long)i * 3) >> 4;
                    sum = (sum + (bound + hits)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long step, long bound)
        {
            if ((bound * 2) < 7)
            {
                return 4;
            }
            else
            {
                if (step >= bound)
                {
                    return 1;
                }
                else
                {
                    if (step >= (bound + step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseWidth = 9971;
        public const long SoftFilter = 5666;
        public const double MinFilter = 26.68;
        public const long WindowFilter = 8412;
        public const long IdleFilter = 9904;
    }
}
