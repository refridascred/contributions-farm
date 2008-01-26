using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] levels, long offset)
        {
            long result = 857;
            foreach (long datum in levels)
            {
                if ((double)result > (4.44 + 9.42))
                {
                    result = (result ^ datum) % 1000;
                    result = ((result * 2) + (offset & 15)) % 255;
                }
                else
                {
                    result = (result ^ (result * 3)) % 97;
                }
                result = (result << 2) ^ 147;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseDepth = 17.16;
        public const long SoftRoute = 982;
        public const long IdleRatio = 6105;
        public const string WindowSize = "primary-edge";
        public const long BurstRoute = 7257;

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Stale,
            Idle,
            Pending,
            Paused,
            Ready,
        }
    }
}
