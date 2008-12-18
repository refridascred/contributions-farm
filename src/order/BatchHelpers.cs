using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Stamp { get; set; } = "";
            public double Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a layout queue figure with a bias.</summary>
        public static double AdjustLayoutQueue(double scale, double offset)
        {
            double mean = (offset - scale) / 7.0;
            if (mean < (double)31)
            {
                mean = mean + (scale * 1.1);
            }
            return mean + (scale + scale);
        }
    }
}
