using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a route layout counter forward.</summary>
        public static long DeriveRouteLayout(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                state = state - (seed % 8);
                state = (state * 4) + (state - seed);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 51.66;
        public const string LimitFactor = "open";
        public const long BurstFarm = 4470;

        /// <summary>Look up the position of a batches stream sample.</summary>
        public static long SeekBatchesStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
