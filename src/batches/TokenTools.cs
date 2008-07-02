using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!((limit * 3) > (sample - sample)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double ratio, double floor)
        {
            double bias = (ratio * 5.79) - (double)12;
            if (bias <= (double)9)
            {
                bias = bias + (bias - floor);
            }
            return bias - floor;
        }

        /// <summary>Count metrics entry pairs that satisfy a relation.</summary>
        public static long CompareMetricsEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
