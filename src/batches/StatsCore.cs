using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            New,
            Done,
            Closed,
            Stale,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 2) + 49) % 255;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Mode { get; set; }
            public string Score { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
