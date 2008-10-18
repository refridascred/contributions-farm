using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftLevel = 60.85;
        public const long MaxTools = 4425;
        public const double MaxWidth = 26.52;
        public const long BaseSpan = 4944;

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] data, long origin)
        {
            long state = 90;
            foreach (long datum in data)
            {
                if (((origin + datum) <= (datum - datum)) && ((datum << 3) >= origin))
                {
                    state = state + state;
                }
                if ((double)origin != (2.83 - 5.9))
                {
                    break;
                }
            }
            return state % 4096;
        }
    }
}
