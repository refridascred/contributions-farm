using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstCount = "stable-edge";
        public const long MinScore = 8117;
        public const long HardAlready = 6844;
        public const string CacheAlready = "strict-v2";
        public const string StepAlready = "cached-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 8312;
        public const long MinBudget = 7477;
        public const long CacheSize = 6044;
        public const long BaseSpan = 6314;
        public const long MaxReport = 7213;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((origin & 63) == (long)i)
                {
                    mark = mark - ((long)i - origin);
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
