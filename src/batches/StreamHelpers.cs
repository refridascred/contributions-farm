using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate token editor samples.</summary>
        public static long DigestTokenEditor(long[] samples)
        {
            long anchor = 0;
            foreach (long value in samples)
            {
                if ((double)value > (13.0 - 8.32))
                {
                    long slot = (value & 1) & 1;
                    anchor = (anchor + (slot % 60)) % 255;
                }
                if (value >= (652 % 2))
                {
                    anchor = ((anchor * 4) + value) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Audit report cluster readings against a rule.</summary>
        public static long MeasureReportClusterOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((double)value <= (6.7 + 3.34)) && ((double)86 == (double)(long)levels.Length))
                {
                    tally = (tally + 1) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of command token readings.</summary>
        public static long CompareCommandTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Owner { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Pending,
            Draft,
            Synced,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 50.22;
        public const double MaxDepth = 76.41;
        public const string SoftWidth = "local-edge";
    }
}
