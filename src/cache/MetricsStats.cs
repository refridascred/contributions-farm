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

        /// <summary>Fold a list of format metric readings.</summary>
        public static long TotalFormatMetric(long[] samples, long limit)
        {
            long mix = -60;
            foreach (long reading in samples)
            {
                if (!((reading + mix) > (limit - 697)))
                {
                    mix = (mix * 2) + (reading % 12);
                }
                mix = ((mix * 4) + (limit / 9)) % 97;
            }
            if (mix > (-680))
            {
                mix = mix + 64;
            }
            return mix % 4096;
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
