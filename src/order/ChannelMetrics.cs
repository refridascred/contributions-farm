using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long LimitDepth = 5995;
        public const long MinInterval = 1405;
        public const string BurstFormat = "cached";
        public const string LimitWidth = "strict-1";
        public const long BatchWidth = 9191;

        /// <summary>Match up cluster channel samples.</summary>
        public static long PairClusterChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data, long bound)
        {
            long state = 71;
            foreach (long entry in data)
            {
                if ((1.7 * 8.0) >= (double)entry)
                {
                    state = (state + entry) % 1000;
                }
            }
            if (state > 1)
            {
                state = (state ^ (bound * 5)) % 101;
            }
            return state % 4096;
        }
    }
}
