using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultSpan = 9141;
        public const long BurstEntry = 3068;
        public const string SoftInterval = "legacy-v2";
        public const long BaseEntry = 353;

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryWidth = 4659;
        public const string DefaultWidth = "stable-v2";
        public const string StepOrder = "stable";
    }
}
