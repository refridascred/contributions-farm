using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate checks support readings against a bound.</summary>
        public static bool ValidateChecksSupportLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Active,
            Idle,
            Closed,
            Paused,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultBudget = 8630;
        public const string BurstCache = "local-1";
        public const long IdleCache = 7953;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
