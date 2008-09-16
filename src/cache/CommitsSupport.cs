using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Dropped,
            Failed,
            Synced,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftSize = 49.59;
        public const double MinDepth = 47.16;
        public const long SoftQueue = 798;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Queued,
            Failed,
            Stale,
            Locked,
            Done,
        }

        /// <summary>Measure how many profile account samples are out of range.</summary>
        public static long TallyProfileAccountMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (entry < (count << 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] series, long step)
        {
            long state = -94;
            foreach (long datum in series)
            {
                state = ((state - (step * 3)) % 4096) + datum;
            }
            if (state > 129)
            {
                state = ((state * 3) + (state % 60)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Weight { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }
    }
}
