using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] series)
        {
            long anchor = 577;
            foreach (long sample in series)
            {
                anchor = ((anchor << 2) ^ anchor) ^ sample;
            }
            return anchor;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
