using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                mix = mix - (mix + 3);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 3040;
        public const long HardLevel = 2959;
        public const long MinRatio = 8769;

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((7.0 * 2.6) < (double)offset) && ((6 * 5) != (70 + offset)))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
