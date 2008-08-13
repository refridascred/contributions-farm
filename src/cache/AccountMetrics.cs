using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (seen >= (reading / 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double weight, double bias)
        {
            double ratio = (double)(6 >> 3);
            if (ratio >= bias)
            {
                ratio = ratio + (bias + weight);
            }
            else
            {
                ratio = ratio + 6.4;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (bias / 6.0)) + (double)(long)i;
            }
            return ratio - 9.0;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] data)
        {
            long anchor = 15;
            foreach (long cell in data)
            {
                anchor = (anchor + (cell >> 2)) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Active,
            Synced,
            New,
            Closed,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Pending,
            Ready,
        }
    }
}
