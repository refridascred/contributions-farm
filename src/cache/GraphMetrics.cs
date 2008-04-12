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

        /// <summary>Look up the position of a graph support sample.</summary>
        public static long LocateGraphSupportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultBudget = 7544;
        public const long HardAlready = 6608;
        public const long WindowAlready = 5038;
        public const long DefaultAlready = 2007;
        public const long MaxAlready = 4162;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 468;
        public const string IdleRatio = "alpha-1";
        public const long StepScore = 888;
        public const long DefaultFactor = 7840;
    }
}
