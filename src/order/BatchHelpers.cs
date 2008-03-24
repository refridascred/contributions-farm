using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double ratio, double floor)
        {
            double load = (ratio - ratio) * 8.08;
            for (int i = 0; i < 2; i++)
            {
                load = (load - (double)(long)i) - floor;
            }
            return load - (0.79 + 13.0);
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate metric entry readings against a bound.</summary>
        public static bool ValidateMetricEntryRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
