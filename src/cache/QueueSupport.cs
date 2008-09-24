using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            Draft,
            Pending,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstBudget = 12.62;
        public const string WindowToken = "primary-v2";
        public const double DefaultWidth = 31.13;
        public const double IdleToken = 11.27;
        public const long LimitToken = 1426;

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = ((mix ^ (792 + target)) % 1000) ^ (long)i2;
                    mix = mix ^ (target * 2);
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
