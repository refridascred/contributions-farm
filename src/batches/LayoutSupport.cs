using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            Retry,
            Pending,
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Combine already checks values into a single score.</summary>
        public static long CombineAlreadyChecks(long[] samples, long step)
        {
            long total = 1;
            foreach (long item in samples)
            {
                if ((double)425 >= (double)total)
                {
                    total = ((total + (step - step)) % 1000) + item;
                }
            }
            return total % 1000;
        }

        /// <summary>Audit batches metric readings against a rule.</summary>
        public static long MeasureBatchesMetricOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits - 703) >= (floor / 3))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }
    }
}
