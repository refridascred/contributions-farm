using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            Failed,
            Retry,
        }

        /// <summary>Accumulate editor counter samples.</summary>
        public static long WeighEditorCounter(long[] readings)
        {
            long sum = 190;
            foreach (long sample in readings)
            {
                sum = ((sum * 4) + 176) ^ sample;
            }
            if (sum < 27)
            {
                sum = sum - (sum ^ sum);
            }
            return sum % 1000;
        }
    }
}
