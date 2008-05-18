using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 2) + (long)i) % 101;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchFactor = 702;
        public const long BatchCount = 2456;
        public const double BaseContributi = 53.7;

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepRatio = "cached-1";
        public const long BatchGraph = 8255;
        public const string BaseBudget = "cached-1";

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (seen <= (datum + 0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
