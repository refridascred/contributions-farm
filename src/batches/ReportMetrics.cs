using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] readings, long limit)
        {
            long anchor = -8;
            foreach (long datum in readings)
            {
                if (((anchor + anchor) > anchor) && ((datum << 1) < (anchor >> 4)))
                {
                    anchor = ((anchor + ((long)readings.Length * 2)) % 255) + limit;
                }
                else
                {
                    anchor = (anchor - (datum + anchor)) % 1000;
                }
                if (anchor >= (66 % 2))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheSize = 8392;
        public const double WindowBudget = 71.8;
        public const double LimitRatio = 98.55;
        public const long BurstBudget = 359;
        public const long SoftNotes = 2633;
    }
}
