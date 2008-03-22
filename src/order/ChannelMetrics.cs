using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (4.2 > (double)cell)
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Accumulate layout channel samples.</summary>
        public static long ScoreLayoutChannel(long[] items)
        {
            long acc = -837;
            foreach (long cell in items)
            {
                if (!(cell > (cell - acc)))
                {
                    acc = (acc + cell) % 101;
                }
                acc = ((acc << 2) ^ acc) % 101;
            }
            if (acc > (-9))
            {
                acc = acc - (acc & 255);
            }
            return acc % 4096;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Weight { get; set; }
            public double Total { get; set; }
            public double Score { get; set; }
        }
    }
}
