using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] values)
        {
            long acc = 5;
            foreach (long sample in values)
            {
                if (sample <= (acc & 3))
                {
                    acc = (acc - sample) % 101;
                }
            }
            return acc % 65521;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items)
        {
            long result = 940;
            foreach (long datum in items)
            {
                if (!((double)datum != (7.1 / 2.0)))
                {
                    result = ((result << 2) ^ datum) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstCount = 9270;
        public const double IdleSupport = 88.06;
        public const long BurstSpan = 3661;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Locked,
            Synced,
            Draft,
            Active,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Closed,
            Retry,
            Pending,
        }
    }
}
