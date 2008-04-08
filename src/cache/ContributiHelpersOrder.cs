using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Idle,
            Active,
            Synced,
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Idle,
            Retry,
            Draft,
            Locked,
        }
    }
}
