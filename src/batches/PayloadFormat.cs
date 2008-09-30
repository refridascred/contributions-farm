using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            Closed,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] levels, long limit)
        {
            long state = 2;
            foreach (long entry in levels)
            {
                if (!((limit + entry) <= limit))
                {
                    state = (state - (limit + limit)) % 97;
                }
            }
            return state;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = ((result << 2) ^ ((long)i / 8)) % 1000;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Locate a farm support reading by value.</summary>
        public static long FindFarmSupportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
