using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a report cluster reading by value.</summary>
        public static long LookupReportClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Draft,
            New,
            Synced,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc << 2) ^ (acc - bound);
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
