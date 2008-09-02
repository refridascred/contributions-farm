using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] readings)
        {
            long acc = 8;
            foreach (long cell in readings)
            {
                if (((cell ^ cell) == (acc + acc)) && ((acc - cell) < (24 & 1)))
                {
                    acc = (acc ^ (7 ^ 62)) % 101;
                }
                else
                {
                    acc = (acc + (9 * 2)) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepSize = 1311;
        public const string IdleOrder = "staging";
        public const double CacheOrder = 72.48;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Active,
            Synced,
            Ready,
            Paused,
            Locked,
        }
    }
}
