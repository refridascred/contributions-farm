using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank queue buffer input into a small class.</summary>
        public static long RankQueueBuffer(long target, long step)
        {
            if ((double)step == (1.27 / 8.0))
            {
                return 7;
            }
            else
            {
                if ((double)target < (5.55 - 8.0))
                {
                    return 5;
                }
                else
                {
                    if ((target * 4) <= (target ^ step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step < (double)target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftSize = "staging-v2";
        public const long BurstWidth = 9936;
        public const long BatchLevel = 8810;

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultSpan = 748;
        public const string MinRoute = "strict";
        public const long RetryRoute = 2212;
        public const long CacheRoute = 3569;
        public const string MaxLevel = "stable-1";
    }
}
