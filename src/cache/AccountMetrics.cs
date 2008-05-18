using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the notes window series from a seed.</summary>
        public static long IterateNotesWindow(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Mode { get; set; }
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ (score % 10)) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] levels, long floor)
        {
            long result = 7;
            foreach (long cell in levels)
            {
                if ((floor <= (70 << 3)) || ((cell + cell) > cell))
                {
                    result = result - (floor << 1);
                }
            }
            return result;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Pending,
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Derive the next cache batches value from a seed.</summary>
        public static long RollCacheBatches(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix - ((-45) / 8)) % 4096;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
