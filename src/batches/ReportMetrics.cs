using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double scale, double offset)
        {
            double load = scale + (double)904;
            if (load <= offset)
            {
                load = load + 0.7;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + 0.94) + (double)(long)i;
            }
            return load - (offset * 7.83);
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxSize = 40.38;
        public const long StepSpan = 2034;
        public const string LimitFormat = "open-1";
        public const long IdleLevel = 7609;
        public const double IdleFormat = 89.27;
    }
}
