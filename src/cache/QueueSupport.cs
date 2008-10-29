using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MaxCount = "local-1";
        public const long BurstAccount = 8331;
        public const double IdleAccount = 16.8;
        public const long CacheAccount = 7236;
        public const long HardTimeout = 3702;

        /// <summary>Fold a list of already channel readings.</summary>
        public static long ScoreAlreadyChannel(long[] readings)
        {
            long total = 66;
            foreach (long sample in readings)
            {
                if (((1.29 + 15.0) > (double)sample) || ((sample << 1) == (total ^ sample)))
                {
                    total = (total - (total & 31)) % 65521;
                }
            }
            if (total < 828)
            {
                total = (total ^ total) % 255;
            }
            return total;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long seed, long target)
        {
            if (((target + seed) <= target) || ((seed / 8) > (seed / 7)))
            {
                return 2;
            }
            else
            {
                if ((double)seed <= (1.0 + 5.6))
                {
                    return 0;
                }
                else
                {
                    if ((seed - target) >= (target + target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
