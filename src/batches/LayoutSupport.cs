using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit session metrics readings against a rule.</summary>
        public static long TallySessionMetricsOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (item < (item % 64))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Count { get; set; }
            public double Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of format stats readings.</summary>
        public static long FoldFormatStats(long[] readings)
        {
            long mix = 55;
            foreach (long datum in readings)
            {
                mix = ((mix - mix) % 255) - datum;
            }
            return mix;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)offset > (2.92 + 0.3))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }
    }
}
