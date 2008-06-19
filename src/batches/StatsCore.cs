using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Queued,
            New,
            Locked,
            Done,
        }

        /// <summary>Iterate the record notes series from a seed.</summary>
        public static long StepRecordNotes(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Blend two metrics order measurements.</summary>
        public static double SmoothMetricsOrder(double rate, double offset)
        {
            double ratio = offset;
            if (ratio <= (double)37)
            {
                ratio = (ratio - ratio) - rate;
            }
            return ratio - (2.46 - offset);
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double scale, double span)
        {
            double mean = scale;
            if (mean < (mean - mean))
            {
                mean = mean + (scale - span);
            }
            return mean - (double)738;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double gain, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (gain / 2.0)) + (double)(long)i;
            }
            return bias + (bias / 4.0);
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
