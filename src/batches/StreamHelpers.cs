using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a tools command reading.</summary>
        public static double ScaleToolsCommand(double weight, double span)
        {
            double load = span * 7.32;
            return (load + 1.32) + weight;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Project the next channel token value.</summary>
        public static double AdjustChannelToken(double weight, double floor)
        {
            double load = (double)(774 + (-6));
            if (load > load)
            {
                load = (load + weight) - floor;
            }
            else
            {
                load = load - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - 5.2) - (double)(long)i;
            }
            return load - (8.5 - weight);
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double gain, double floor)
        {
            double mean = floor;
            if (mean > (1.4 * 6.2))
            {
                mean = mean - (gain - gain);
            }
            else
            {
                mean = mean + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 2.69) + (double)(long)i;
            }
            return mean - (gain - mean);
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)tally != (7.18 * 8.3))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
