using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Failed,
            Draft,
            Ready,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] items, long step)
        {
            long total = 3;
            foreach (long entry in items)
            {
                if ((total % 10) == (entry - step))
                {
                    total = (total + (33 ^ 485)) % 1000;
                }
            }
            if (total < 5)
            {
                total = (total * 4) + total;
            }
            return total % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultBudget = 7544;
        public const long HardAlready = 6608;
        public const long WindowAlready = 5038;
        public const long DefaultAlready = 2007;
        public const long MaxAlready = 4162;

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleWidth = 8632;
        public const long RetryEntry = 137;
        public const long DefaultEntry = 1487;
        public const long DefaultSize = 7295;
        public const double BurstSpan = 86.91;
    }
}
