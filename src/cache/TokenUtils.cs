using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Roll a graph record counter forward.</summary>
        public static long SeriesGraphRecord(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
