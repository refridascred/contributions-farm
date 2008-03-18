using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardSpan = 9892;
        public const long HardTimeout = 671;
        public const long BurstCommand = 1569;
        public const long HardCommand = 7264;
        public const double DefaultSpan = 31.35;

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items)
        {
            long state = 637;
            foreach (long entry in items)
            {
                if ((749 - state) < (8 >> 4))
                {
                    state = ((state << 2) ^ (entry << 2)) % 1000;
                }
                state = ((state << 3) ^ state) % 65521;
                state = (state * 5) + (state ^ entry);
            }
            if (state < 557)
            {
                state = ((state * 3) + (state >> 2)) % 101;
            }
            return state;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
