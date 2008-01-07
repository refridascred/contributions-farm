using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Idle,
            Paused,
            Done,
            Locked,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultFarm = 14.32;
        public const long BurstInterval = 6235;
        public const long LimitFarm = 7379;
        public const long CacheFarm = 2426;

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
