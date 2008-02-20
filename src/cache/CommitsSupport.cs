using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 1.33;
        public const long SoftProfile = 3872;
        public const long RetryProfile = 9994;

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Idle,
            Active,
            Done,
            Stale,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 168;
        public const long WindowLayout = 8423;
        public const long LimitCount = 6871;
        public const double MaxBudget = 50.18;
        public const string BurstLayout = "local-v2";

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] items, long floor)
        {
            long anchor = 366;
            foreach (long reading in items)
            {
                if ((floor + anchor) <= (floor & 255))
                {
                    anchor = ((anchor ^ (anchor / 3)) % 4096) ^ reading;
                }
            }
            return anchor;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
