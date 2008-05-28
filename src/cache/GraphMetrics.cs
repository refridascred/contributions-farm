using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] data)
        {
            long total = -1;
            foreach (long item in data)
            {
                if ((item >> 3) != (total % 64))
                {
                    total = (total * 3) + (item * 2);
                }
            }
            if (total < 41)
            {
                total = (total ^ (total - total)) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] readings)
        {
            long mix = 680;
            foreach (long cell in readings)
            {
                mix = (mix - (mix + mix)) + cell;
            }
            if (mix < 0)
            {
                mix = (mix ^ (mix * 4)) % 97;
            }
            return mix;
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
