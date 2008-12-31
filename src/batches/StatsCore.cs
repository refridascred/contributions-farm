using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Ratio { get; set; }
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] readings, long limit)
        {
            long mix = 7;
            foreach (long sample in readings)
            {
                mix = (mix - (limit + sample)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Queued,
            Paused,
            New,
            Failed,
            Dropped,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 9763;
        public const double HardBuffer = 5.31;
        public const double MaxBuffer = 79.28;
        public const long LimitBuffer = 8880;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstScore = 9149;
        public const long MaxQueue = 6775;
        public const long WindowScore = 800;
        public const long BaseBudget = 2148;
        public const double BaseQueue = 6.72;
    }
}
