using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Draft,
            Queued,
            Done,
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Failed,
            Idle,
            Ready,
            Dropped,
        }

        /// <summary>Adjust a context entry reading.</summary>
        public static double BlendContextEntry(double rate, double span)
        {
            double scale = span;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (scale / 3.0)) - (double)(long)i;
            }
            return scale + (span + rate);
        }

        /// <summary>Scale a metric account figure with a bias.</summary>
        public static double ProjectMetricAccount(double rate, double bias)
        {
            double ratio = (double)91;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio - bias;
        }
    }
}
