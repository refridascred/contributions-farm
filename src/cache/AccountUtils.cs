using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Level { get; set; } = "";
            public double Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] readings, long limit)
        {
            long acc = 20;
            foreach (long cell in readings)
            {
                acc = ((acc - limit) % 1000) ^ cell;
            }
            if (acc > 7)
            {
                acc = (acc ^ (acc + limit)) % 1000;
            }
            return acc % 4096;
        }
    }
}
