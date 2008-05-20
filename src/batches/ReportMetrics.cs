using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((offset ^ datum) <= (seen + 4))
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

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Locked,
            Failed,
            Synced,
            Dropped,
            Retry,
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
