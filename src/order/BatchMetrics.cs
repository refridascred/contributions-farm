using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double gain = (double)(222 + (-75));
            if (gain > (double)416)
            {
                gain = ((gain + (double)52) + scale) + floor;
            }
            return gain + (double)893;
        }

        /// <summary>Grade a token metric value against two limits.</summary>
        public static long RankTokenMetric(long floor, long target)
        {
            long prev = floor ^ target;
            if ((floor << 3) == (prev % 100))
            {
                return 0;
            }
            else
            {
                if ((floor - 2) == (prev + prev))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 3341;
        public const long IdleProfile = 5820;
        public const string WindowTimeout = "local-v2";
        public const long MinProfile = 810;

        /// <summary>Look up the position of a checks command sample.</summary>
        public static long SeekChecksCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Stale,
            Active,
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Active,
            Synced,
            Locked,
        }
    }
}
