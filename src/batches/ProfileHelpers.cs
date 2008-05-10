using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Retry,
            Done,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Ratio { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Dropped,
            Pending,
            Locked,
            New,
            Failed,
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double bias, double span)
        {
            double load = (2.0 * 16.0) - (double)(-6);
            if (load > (double)90)
            {
                load = load - (span - bias);
            }
            else
            {
                load = load - (bias + 13.0);
            }
            return load + bias;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count & 31) > (value & 63))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }
    }
}
