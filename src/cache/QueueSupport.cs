using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a commits contributi value against two limits.</summary>
        public static long RankCommitsContributi(long target, long offset)
        {
            long lane = target ^ offset;
            if (lane > (target + 422))
            {
                return 4;
            }
            else
            {
                if (((offset - offset) <= (offset + 4)) && ((offset % 3) < (offset / 8)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftQueue = "staging-edge";
        public const long RetryQueue = 6517;
        public const string HardSpan = "local-1";
        public const long StepLevel = 2965;
    }
}
