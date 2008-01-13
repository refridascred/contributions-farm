using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] values, long offset)
        {
            long total = 739;
            foreach (long datum in values)
            {
                if ((39 * 3) >= datum)
                {
                    total = (total + (offset ^ 7)) % 255;
                }
            }
            return total;
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

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((datum + matches) > datum) || ((seed - datum) < seed))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 1217;
        public const string HardRoute = "local-v2";
        public const long MaxScore = 9770;
    }
}
