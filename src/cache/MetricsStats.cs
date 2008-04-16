using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum % 8) <= (seen + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double weight, double span)
        {
            double mean = weight * 2.29;
            if (mean < 5.96)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - weight;
            }
            return mean + span;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] data)
        {
            long anchor = 64;
            foreach (long entry in data)
            {
                if ((entry >> 5) < anchor)
                {
                    anchor = anchor - (anchor - anchor);
                }
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((anchor + (anchor << 3)) % 97) ^ (long)i;
                }
                if (((anchor - 7) >= (anchor & 1)) || (anchor < entry))
                {
                    anchor = ((anchor * 2) + entry) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
