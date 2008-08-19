using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "legacy-edge";
        public const double LimitMetrics = 24.0;
        public const long CacheScore = 7493;
        public const long CacheMetrics = 2443;
        public const string CacheCount = "latest";

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Closed,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two contributi filter measurements.</summary>
        public static double AdjustContributiFilter(double rate, double span)
        {
            double drift = (span * 5.5) - rate;
            if (drift <= (span * 2.0))
            {
                drift = drift + (rate + span);
            }
            else
            {
                drift = drift + 7.0;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 3.0) - (double)(long)i;
            }
            return drift + (13.0 * 5.5);
        }

        /// <summary>Match up schema account samples.</summary>
        public static long OverlapSchemaAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
