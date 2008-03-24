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

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Closed,
            Done,
            Locked,
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
