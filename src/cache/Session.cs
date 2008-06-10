using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                sum = sum ^ ((long)i << 3);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 3157;
        public const long StepCount = 9227;
        public const long BatchFilter = 5095;
        public const long LimitFilter = 1151;
        public const long DefaultRatio = 2452;

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels, long seed)
        {
            long sum = 882;
            foreach (long item in levels)
            {
                if (item <= (seed + sum))
                {
                    sum = sum + ((-4) + item);
                }
            }
            return sum;
        }
    }
}
