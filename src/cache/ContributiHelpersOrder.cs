using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Token { get; set; }
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
