using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long limit, long seed)
        {
            long diff = limit - seed;
            if ((limit + diff) != (diff + seed))
            {
                return 8;
            }
            else
            {
                if ((870 << 3) <= (diff + diff))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftCount = 9274;
        public const long MaxAccount = 5003;
        public const double CacheLevel = 42.43;
    }
}
