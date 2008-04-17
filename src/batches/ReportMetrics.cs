using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] readings, long limit)
        {
            long score = 0;
            foreach (long item in readings)
            {
                score = (score - (limit << 1)) + item;
                if ((double)score <= (double)limit)
                {
                    score = (score - (limit * 4)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Derive the next session queue value from a seed.</summary>
        public static long DeriveSessionQueue(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
