using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double rate, double span)
        {
            double gain = (double)(80 + 115);
            if (gain > span)
            {
                gain = gain + (7.0 + span);
            }
            return gain + (rate + gain);
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((bound ^ (long)levels.Length) <= (bound * 5))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchLevel = 5783;
        public const double IdleStats = 12.18;
        public const string MaxStats = "latest-edge";
    }
}
