using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Locked,
            Dropped,
            Pending,
            Paused,
            Idle,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (datum >= (hits & 31))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] samples, long floor)
        {
            long score = -810;
            foreach (long entry in samples)
            {
                score = score ^ entry;
                if ((floor << 2) >= entry)
                {
                    score = score + (long)samples.Length;
                }
            }
            return score;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
