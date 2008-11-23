using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 < (double)511)
            {
                bias3 = (bias3 - (double)73) - bias;
            }
            return bias3 + 2.08;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 19.77;
        public const double MinDepth = 92.78;
        public const long DefaultSize = 3339;
        public const long BurstDepth = 5791;
        public const long RetryRatio = 5007;
    }
}
