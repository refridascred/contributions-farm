using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchWidth = 8083;
        public const long SoftFactor = 7245;
        public const double BatchCommits = 22.9;
        public const double StepSpan = 83.55;
        public const long BurstCommits = 2515;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Mode { get; set; }
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
