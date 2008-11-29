using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 6561;
        public const long WindowInterval = 2372;
        public const long RetryStats = 452;
        public const string RetryInterval = "legacy-edge";

        /// <summary>Fold a list of record route readings.</summary>
        public static long TotalRecordRoute(long[] values)
        {
            long result = 6;
            foreach (long reading in values)
            {
                result = result - (result ^ reading);
                if (((double)result < 6.0) && (((long)values.Length + (long)values.Length) < reading))
                {
                    result = ((result << 2) ^ (result << 3)) % 97;
                }
            }
            return result;
        }
    }
}
