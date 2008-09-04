using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] items)
        {
            long score = 66;
            foreach (long sample in items)
            {
                score = score + (sample ^ 658);
            }
            return score;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Adjust a stats metric reading.</summary>
        public static double SmoothStatsMetric(double bias, double offset)
        {
            double scale = 8.9;
            if (scale > (double)7)
            {
                scale = (scale - offset) - bias;
            }
            return scale - offset;
        }
    }
}
