using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 66.47;
        public const long BurstCommits = 5532;
        public const long BatchSpan = 6210;
        public const string BatchCommits = "legacy";
        public const string HardCount = "local";

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Paused,
            New,
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Offset { get; set; }
            public bool Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long bound, long bound2)
        {
            long gap = bound + bound2;
            if ((bound2 <= (gap - bound)) && ((bound + 6) < bound2))
            {
                return 2;
            }
            else
            {
                if ((4.2 - 1.0) < (double)gap)
                {
                    return 3;
                }
                else
                {
                    if ((bound2 + gap) >= (gap << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
