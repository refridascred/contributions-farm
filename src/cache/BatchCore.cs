using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 2979;
        public const long IdleFormat = 8104;
        public const long SoftDepth = 8401;
        public const long WindowScore = 9124;
        public const string WindowFormat = "primary";

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                long diff = (acc % 7) - (floor >> 4);
                if (diff <= (acc + diff))
                {
                    diff = diff ^ ((long)i + 0);
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
            public double Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((((entry / 3) >= ((long)levels.Length - 876)) || ((limit - 804) == (seen << 1))) && ((10.0 * 2.3) <= (double)entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
