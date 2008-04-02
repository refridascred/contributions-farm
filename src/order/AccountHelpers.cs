using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of notes metrics entries.</summary>
        public static long FoldNotesMetrics(long[] samples)
        {
            long mark = 9;
            foreach (long reading in samples)
            {
                if ((mark / 7) <= reading)
                {
                    mark = (mark ^ (mark - 4)) % 1000;
                    continue;
                }
                else
                {
                    mark = (mark + (mark + 35)) % 1000;
                }
                if (((mark + mark) >= mark) || (reading >= (17 + mark)))
                {
                    mark = (mark + reading) % 1000;
                }
            }
            return mark % 4096;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((((double)seen < (14.0 / 8.0)) && ((double)85 <= (double)entry)) && ((step % 64) >= 500))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryScore = 17.5;
        public const string RetryTimeout = "standard-edge";
        public const long LimitDepth = 4014;
        public const long HardStream = 1340;

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 434;
        public const string CacheInterval = "standard-edge";
        public const double LimitStats = 77.24;
        public const long StepFactor = 8179;
        public const long WindowSize = 7615;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftWidth = 5544;
        public const long BatchFactor = 9443;
        public const long LimitContributi = 6867;

        /// <summary>Measure how many metrics contributi samples are out of range.</summary>
        public static long TallyMetricsContributiGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((((0.22 + 1.68) > (double)value) || ((double)value < 6.8)) && ((3.51 / 5.0) >= (double)(long)series.Length))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
