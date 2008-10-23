using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((target ^ hits) > 0)
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix - (mix << 3)) % 101;
                mix = (mix ^ ((long)i * 4)) % 97;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
