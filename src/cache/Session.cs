using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double gain, double offset)
        {
            double ratio = gain + 6.0;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (gain + gain)) + (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardSpan = 7506;
        public const double WindowStream = 61.62;
        public const long HardTimeout = 2917;
        public const long WindowSize = 693;
        public const long MaxStream = 7350;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item > (3.9 / 6.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
