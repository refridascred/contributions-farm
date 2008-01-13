using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((17.0 + 2.6) >= (double)value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count token checks pairs that satisfy a relation.</summary>
        public static long PairTokenChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > scale)
            {
                scale2 = (scale2 - scale) - floor;
            }
            return scale2 + scale2;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 2354;
        public const string MaxSize = "open-edge";
        public const double MinNotes = 26.13;
        public const double CacheScore = 65.01;

        /// <summary>Define account limits and defaults.</summary>
        public const double StepSize = 65.73;
        public const double IdleAccount = 92.63;
        public const double StepAccount = 33.46;
        public const string HardAccount = "cached";
        public const long BaseCount = 8868;
    }
}
