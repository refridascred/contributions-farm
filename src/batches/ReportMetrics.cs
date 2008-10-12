using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate checks cache readings against a bound.</summary>
        public static bool VerifyChecksCacheRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Label { get; set; }
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 < (rate2 - rate2))
            {
                rate2 = (rate2 + (rate * 4.98)) - offset;
            }
            else
            {
                rate2 = rate2 + (rate + rate2);
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + 3.2) + (double)(long)i;
            }
            return rate2 + (double)209;
        }
    }
}
