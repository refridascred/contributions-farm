using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count window cluster pairs that satisfy a relation.</summary>
        public static long CompareWindowClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] items)
        {
            long mix = 413;
            foreach (long datum in items)
            {
                if (((mix & 3) >= 670) && ((datum - mix) < datum))
                {
                    mix = ((mix << 3) ^ ((-694) + datum)) % 65521;
                }
            }
            return mix % 1000;
        }
    }
}
