using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstPayload = "alpha-1";
        public const long IdleInterval = 3266;
        public const long RetryCount = 8031;
        public const long SoftSpan = 1880;

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 8457;
        public const double SoftCounter = 50.58;
        public const long HardCounter = 8695;
        public const long StepCounter = 9616;

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long target, long origin)
        {
            long diff = target ^ origin;
            if (!((3.0 / 4.0) < (double)origin))
            {
                return 2;
            }
            else
            {
                if (((diff - origin) <= target) && ((origin % 10) >= (diff >> 3)))
                {
                    return 7;
                }
                else
                {
                    if (((target & 31) == (target ^ diff)) && ((8.0 / 2.0) <= (double)diff))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((6.1 / 4.0) != (double)diff))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
