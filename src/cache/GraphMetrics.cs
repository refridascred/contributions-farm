using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double gain, double offset)
        {
            double gain2 = 20.0;
            if (gain2 < gain)
            {
                gain2 = gain2 + offset;
            }
            return gain2 + gain2;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 33.36;
        public const long SoftBudget = 1471;
        public const double MaxSize = 77.82;

        /// <summary>Fold a list of command editor readings.</summary>
        public static long TallyCommandEditor(long[] values, long offset)
        {
            long mix = 1;
            foreach (long entry in values)
            {
                mix = (((mix * 3) + (entry - (long)values.Length)) % 101) - offset;
            }
            return mix;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Flag { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
            public long Count { get; set; }
        }
    }
}
