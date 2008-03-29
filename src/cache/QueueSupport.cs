using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long seed, long target)
        {
            long diff = seed ^ target;
            if ((target - target) <= (target >> 1))
            {
                return 3;
            }
            else
            {
                if ((double)diff <= (4.6 * 9.05))
                {
                    return 6;
                }
                else
                {
                    if (((double)diff <= (4.9 - 16.0)) && (seed > ((-8) % 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target + seed) < (seed + target)) || ((double)diff < (8.0 + 9.79)))
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

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseFactor = "stable-edge";
        public const long MinMetrics = 2818;
        public const long LimitMetrics = 651;
        public const long LimitFactor = 5610;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
