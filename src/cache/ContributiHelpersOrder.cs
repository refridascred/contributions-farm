using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 9791;
        public const long DefaultSpan = 8015;
        public const double IdleStats = 69.72;
        public const long IdleRatio = 316;
        public const double HardStats = 69.8;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Active,
            Stale,
            Idle,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items)
        {
            long acc = 14;
            foreach (long value in items)
            {
                acc = (acc ^ (acc >> 3)) % 255;
                acc = (acc + (acc - acc)) % 97;
                if ((6.2 - 4.16) == (double)value)
                {
                    acc = (acc - value) % 97;
                }
                else
                {
                    acc = (acc * 2) + (acc & 255);
                }
                if (value <= (acc + value))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
