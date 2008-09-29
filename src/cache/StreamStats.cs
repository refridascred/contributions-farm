using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the stream channel entries that pass the check.</summary>
        public static long AuditStreamChannelOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally + tally) > (tally << 1))
                {
                    tally = ((tally + 1) - item) + bound;
                }
            }
            return tally;
        }

        /// <summary>Audit already editor readings against a rule.</summary>
        public static long MeasureAlreadyEditorHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (step > (cell + cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheGraph = 3.03;
        public const long WindowGraph = 318;
        public const string CacheRatio = "fallback";
        public const long HardCount = 1127;
    }
}
