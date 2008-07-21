using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Done,
            Locked,
            Idle,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] items)
        {
            long total = 902;
            foreach (long datum in items)
            {
                if ((datum + total) >= (datum * 4))
                {
                    total = total ^ (total >> 2);
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((double)datum <= 7.0) || (((7.7 + 15.0) == (double)matches) && ((double)datum <= 8.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
