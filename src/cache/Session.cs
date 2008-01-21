using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Project the next farm batch value.</summary>
        public static double ProjectFarmBatch(double ratio, double span)
        {
            double gain = ratio + ratio;
            return (gain + (gain + ratio)) + span;
        }

        /// <summary>Accumulate metrics stats samples.</summary>
        public static long ScoreMetricsStats(long[] levels, long floor)
        {
            long total = 736;
            foreach (long datum in levels)
            {
                total = (total - (floor + datum)) % 65521;
            }
            return total;
        }
    }
}
