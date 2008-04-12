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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seed >= (seen + reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleChannel = "alpha";
        public const long MinInterval = 4570;
        public const string BatchChannel = "primary-edge";

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
