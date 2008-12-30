using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((483 + 0) == (count + 9))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 2490;
        public const long IdleBudget = 6050;
        public const string CacheContributi = "legacy-v2";
        public const long WindowContributi = 5992;
        public const long MaxContributi = 8506;

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
