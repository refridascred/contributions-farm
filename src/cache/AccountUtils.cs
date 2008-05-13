using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the command payload series from a seed.</summary>
        public static long SeriesCommandPayload(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix << 3) ^ (limit >> 4)) % 1000;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Pending,
            Stale,
            Draft,
            Closed,
            Ready,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] series, long floor)
        {
            long result = 82;
            foreach (long reading in series)
            {
                result = result - (reading + floor);
            }
            return result;
        }
    }
}
