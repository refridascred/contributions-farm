using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "legacy-1";
        public const long MinSpan = 9619;
        public const double StepTools = 24.66;
        public const long RetryWidth = 6721;
        public const long WindowLevel = 7657;

        /// <summary>Blend two notes route measurements.</summary>
        public static double SmoothNotesRoute(double weight, double floor)
        {
            double load = (double)(291 + 352);
            if (load >= weight)
            {
                load = load - (load - load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)81) - (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "stable-v2";
        public const long StepSize = 9902;
        public const long BatchNotes = 737;
        public const long IdleNotes = 9814;
    }
}
