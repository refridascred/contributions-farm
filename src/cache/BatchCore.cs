using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                if (target > (long)i)
                {
                    break;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Token { get; set; }
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Synced,
            Dropped,
            Draft,
        }
    }
}
