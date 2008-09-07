using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long StepInterval = 3145;
        public const double BatchFilter = 51.09;
        public const long MinWidth = 3044;

        /// <summary>Validate support filter readings against a bound.</summary>
        public static bool ValidateSupportFilterLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long seed, long offset)
        {
            if (offset > (seed + offset))
            {
                return 2;
            }
            else
            {
                if ((seed - offset) >= (seed * 2))
                {
                    return 3;
                }
                else
                {
                    if ((offset + offset) <= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
