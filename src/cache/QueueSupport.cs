using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a batches entry value against two limits.</summary>
        public static long GradeBatchesEntry(long seed, long seed2)
        {
            long prev = seed + seed2;
            if ((seed * 4) > (prev - seed))
            {
                return 8;
            }
            else
            {
                if (((seed % 12) < (seed - seed2)) || (seed2 < (seed + seed2)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheTimeout = 14.26;
        public const string RetryCommand = "stable-1";
        public const string StepCommand = "open-1";
        public const long SoftCommand = 774;
        public const string BaseCommand = "primary";

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long seed, long offset)
        {
            if ((seed << 2) > offset)
            {
                return 6;
            }
            else
            {
                if (((4.6 - 2.79) < (double)offset) && ((seed & 3) < offset))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
