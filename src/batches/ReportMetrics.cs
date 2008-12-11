using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Count { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a record commits figure with a bias.</summary>
        public static double AdjustRecordCommits(double rate, double bias)
        {
            double scale = rate;
            return (scale - (7.95 - rate)) + bias;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double rate, double offset)
        {
            double scale = offset;
            if (scale >= (double)6)
            {
                scale = (scale - (double)(-11)) - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (double)260;
        }
    }
}
