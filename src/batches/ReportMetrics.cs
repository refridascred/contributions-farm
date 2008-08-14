using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Idle,
            New,
            Stale,
            Synced,
            Dropped,
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Synced,
            Active,
            Failed,
            New,
        }

        /// <summary>Scale a layout contributi figure with a bias.</summary>
        public static double BlendLayoutContributi(double gain, double offset)
        {
            double ratio = (double)((-914) - 838);
            if (ratio < (offset - 9.0))
            {
                ratio = ratio + (double)15;
            }
            return ratio + gain;
        }
    }
}
