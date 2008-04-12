using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample >> 5) >= (sample << 3))
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double rate, double span)
        {
            double weight = rate;
            if (weight < (4.0 * 3.3))
            {
                weight = weight - (span / 8.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + 13.0) + (double)(long)i;
            }
            return weight + (span + rate);
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Total { get; set; }
            public double Count { get; set; }
            public bool Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
