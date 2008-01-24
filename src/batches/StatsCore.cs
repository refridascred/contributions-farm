using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)(long)readings.Length > (4.5 - 14.0))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 1325;
        public const long WindowStats = 2540;
        public const long IdleStats = 9678;
        public const long SoftStats = 5662;
        public const long RetryLevel = 8477;

        /// <summary>Audit metric payload readings against a rule.</summary>
        public static long CountMetricPayloadGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)cell <= (4.9 + 5.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long step, long seed)
        {
            long lane = step + seed;
            if (seed >= (seed + step))
            {
                return 4;
            }
            else
            {
                if ((double)lane >= (3.34 - 19.0))
                {
                    return 2;
                }
                else
                {
                    if (((step << 1) <= lane) && (1 <= (6 - seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
