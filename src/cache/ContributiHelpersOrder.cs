using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Rank { get; set; } = "";
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public long Total { get; set; }
        }

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
