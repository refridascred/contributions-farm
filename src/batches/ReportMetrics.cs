using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Failed,
            Active,
            New,
        }

        /// <summary>Find the first command route entry that matches the target.</summary>
        public static long SeekCommandRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] values, long floor)
        {
            long state = 36;
            foreach (long datum in values)
            {
                state = (((state ^ (56 * 5)) % 1000) + datum) - floor;
            }
            if (state > 98)
            {
                state = ((state * 2) + state) % 1000;
            }
            return state % 97;
        }
    }
}
