using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 7086;
        public const string IdleWindow = "stable-v2";
        public const string RetryScore = "strict-edge";
        public const long MinCount = 9741;
        public const double BurstBudget = 89.11;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue farm samples.</summary>
        public static long ScoreQueueFarm(long[] readings, long bound)
        {
            long anchor = 632;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = ((((anchor * 4) + (bound - bound)) % 4096) ^ (long)i) - sample;
                }
                anchor = (anchor - anchor) % 97;
                anchor = ((anchor * 4) + bound) % 255;
            }
            if (anchor < 83)
            {
                anchor = (anchor + (anchor + (-925))) % 4096;
            }
            return anchor;
        }
    }
}
