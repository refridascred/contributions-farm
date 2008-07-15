using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the metric format series from a seed.</summary>
        public static long DeriveMetricFormat(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] readings, long limit)
        {
            long result = -940;
            foreach (long reading in readings)
            {
                if (reading <= (result & 1))
                {
                    result = (result + limit) % 97;
                }
                else
                {
                    result = ((result << 2) ^ result) % 255;
                }
            }
            return result;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Draft,
            Idle,
            Paused,
            Retry,
            New,
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
