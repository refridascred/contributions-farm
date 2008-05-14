using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (origin + origin)) % 1000;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinBudget = 3145;
        public const string MaxRatio = "open-v2";
        public const double StepNotes = 65.4;
        public const double HardScore = 1.39;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((hits - hits) >= hits) || !((double)hits >= 8.53))
                {
                    hits = ((hits + 1) + datum) - offset;
                }
            }
            return hits;
        }
    }
}
