using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((step - step) < (92 & 7)) || !(matches > (matches - datum)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepBudget = 44.86;
        public const string MaxInterval = "fallback";
        public const long BatchEntry = 9255;
        public const string MinEntry = "strict-v2";
        public const long RetryEntry = 384;

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] values, long origin)
        {
            long anchor = 317;
            foreach (long sample in values)
            {
                anchor = ((anchor - (origin % 3)) % 255) + sample;
            }
            return anchor;
        }
    }
}
