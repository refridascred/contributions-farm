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

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

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

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheWidth = 1122;
        public const string StepWidth = "staging-v2";
        public const long SoftContext = 375;
        public const long CacheContext = 8937;
        public const long BurstContext = 6072;

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
