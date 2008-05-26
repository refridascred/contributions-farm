using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] levels, long seed)
        {
            long acc = -4;
            foreach (long item in levels)
            {
                if ((item / 5) >= acc)
                {
                    acc = ((acc << 3) ^ 5) + seed;
                }
            }
            if (acc > 431)
            {
                acc = (acc - (acc * 4)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Measure how many session commits samples are out of range.</summary>
        public static long TallySessionCommitsGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((2.0 - 4.0) == (double)item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
