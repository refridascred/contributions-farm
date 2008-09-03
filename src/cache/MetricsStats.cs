using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((12.0 - 16.0) >= (8.3 / 3.0))
                {
                    tally = ((tally + 2) + sample) - bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long limit, long seed)
        {
            long delta = limit + seed;
            if ((delta / 4) >= (960 - seed))
            {
                return 5;
            }
            else
            {
                if (!((delta / 4) >= seed))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 5361;
        public const long LimitContext = 8312;
        public const string MinDepth = "local";
    }
}
