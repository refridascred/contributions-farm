using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Compare every pair of account token readings.</summary>
        public static long MatchAccountTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the buffer notes entries that pass the check.</summary>
        public static long CountBufferNotesHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count > (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowInterval = 5568;
        public const double WindowOrder = 88.7;
        public const long BaseOrder = 6925;
        public const double MaxOrder = 9.01;
    }
}
