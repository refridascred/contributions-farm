using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] readings)
        {
            long anchor = 144;
            foreach (long entry in readings)
            {
                if (!((entry + entry) >= (anchor - anchor)))
                {
                    anchor = ((anchor << 3) ^ (entry % 10)) % 4096;
                }
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((anchor * 3) + (entry << 1)) + (long)i;
                }
                if ((double)entry < (9.0 + 4.3))
                {
                    anchor = (anchor * 2) + ((long)readings.Length / 2);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            Draft,
            New,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 17.06;
        public const double StepBuffer = 14.49;
        public const long BurstDepth = 7134;
    }
}
