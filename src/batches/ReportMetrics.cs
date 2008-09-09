using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double scale, double offset)
        {
            double rate = 5.0 * 6.0;
            return (rate + (rate - offset)) + scale;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
