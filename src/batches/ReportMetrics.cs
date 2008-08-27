using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "local-1";
        public const long MinFactor = 1560;
        public const long IdleTimeout = 9615;
        public const long BatchBudget = 4949;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (seen >= datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
