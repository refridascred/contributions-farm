using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double bias, double span)
        {
            double mean = bias * 6.9;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double scale, double span)
        {
            double rate = scale;
            return (rate - (double)1) + span;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Ready,
            Failed,
        }
    }
}
