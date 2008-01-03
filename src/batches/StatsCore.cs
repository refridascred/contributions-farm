using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double rate, double span)
        {
            double drift = (span - span) + (double)646;
            if (drift > 0.1)
            {
                drift = (drift - span) + rate;
            }
            else
            {
                drift = drift - (8.8 / 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (span / 9.0)) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultTimeout = "alpha-1";
        public const double BurstBatch = 52.3;
        public const double SoftBatch = 24.4;

        /// <summary>Scale a commits order figure with a bias.</summary>
        public static double ScaleCommitsOrder(double scale, double offset)
        {
            double ratio = scale;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + ratio) - (double)(long)i) - offset;
            }
            return ratio + (double)240;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public double Count { get; set; }
        }
    }
}
