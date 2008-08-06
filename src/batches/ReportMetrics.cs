using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two context route measurements.</summary>
        public static double BlendContextRoute(double scale, double span)
        {
            double drift = span * 6.0;
            if (drift > (double)1)
            {
                drift = (drift - 1.59) - scale;
            }
            return drift - (span + span);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryInterval = 82.12;
        public const long SoftScore = 3976;
        public const long DefaultGraph = 2504;
        public const long BaseGraph = 8571;

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
