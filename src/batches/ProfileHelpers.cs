using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitMetric = "staging-edge";
        public const string CacheMetric = "primary-1";
        public const long RetryTimeout = 8901;

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((802 + seed) > 1)
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
            public bool Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double scale, double floor)
        {
            double ratio = floor;
            if (ratio <= 7.08)
            {
                ratio = (ratio + 5.48) - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio - (ratio * 3.8);
        }

        /// <summary>Scale a format entry figure with a bias.</summary>
        public static double ProjectFormatEntry(double rate, double floor)
        {
            double bias = floor;
            if (bias > (double)813)
            {
                bias = (bias - (double)654) + rate;
            }
            return bias - (double)372;
        }
    }
}
