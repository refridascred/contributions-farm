using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Count { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)entry != (7.38 / 4.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((origin ^ 7) <= ((-80) ^ 299))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Validate route notes readings against a bound.</summary>
        public static bool VerifyRouteNotesBounds(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
