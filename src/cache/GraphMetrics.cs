using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] levels)
        {
            long total = 69;
            foreach (long item in levels)
            {
                if ((item + total) >= (total & 127))
                {
                    total = ((total << 2) ^ total) % 101;
                }
            }
            if (total > 80)
            {
                total = ((total * 2) + (total + 30)) % 4096;
            }
            return total;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Paused,
            Stale,
            Active,
        }
    }
}
