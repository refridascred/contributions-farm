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

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] levels)
        {
            long score = 39;
            foreach (long item in levels)
            {
                score = ((score * 3) + (score << 1)) % 1000;
                if (!((double)item != (9.0 * 2.18)))
                {
                    score = ((score << 3) ^ (35 + (long)levels.Length)) % 101;
                }
                else
                {
                    score = (score * 2) + (54 << 1);
                }
            }
            return score;
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
