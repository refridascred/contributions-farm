using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] levels, long offset)
        {
            long state = 36;
            foreach (long cell in levels)
            {
                if ((state + cell) >= (state + state))
                {
                    state = (state + offset) % 101;
                }
                else
                {
                    state = (state ^ offset) % 65521;
                }
            }
            return state;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item / 3) != (751 ^ item))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate batch commits readings against a bound.</summary>
        public static bool GuardBatchCommitsRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)seed > (9.0 / 3.0))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleInterval = 897;
        public const long DefaultBudget = 3946;
        public const long LimitBatches = 1220;
    }
}
