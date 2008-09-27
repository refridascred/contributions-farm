using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string StepScore = "alpha";
        public const long BaseCount = 6926;
        public const string BurstFormat = "standard";
        public const double HardSpan = 59.53;
        public const long HardFormat = 100;

        /// <summary>Rank payload metrics input into a small class.</summary>
        public static long RankPayloadMetrics(long bound, long bound2)
        {
            long lane = bound + bound2;
            if (((bound2 & 3) == (lane + bound2)) || ((bound2 + lane) <= bound))
            {
                return 2;
            }
            else
            {
                if (!(bound < (1 + bound2)))
                {
                    return 5;
                }
                else
                {
                    if ((5.6 * 2.71) == (double)lane)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((lane / 3) >= (bound2 >> 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public double Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
