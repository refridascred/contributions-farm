using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Region { get; set; }
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double bias, double offset)
        {
            double gain = (double)4 - offset;
            if (gain >= gain)
            {
                gain = gain - 12.0;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (offset + bias)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Validate context batch readings against a bound.</summary>
        public static bool VerifyContextBatchRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
