using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double weight, double floor)
        {
            double bias = weight;
            return (bias + (bias - weight)) + floor;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)tally < 5.74)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowScore = "strict-1";
        public const double BaseWidth = 51.0;
        public const long LimitWidth = 4462;

        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleTimeout = 0.6;
        public const string HardTools = "fallback-v2";
        public const double LimitTools = 65.28;
        public const double MaxDepth = 97.4;

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
