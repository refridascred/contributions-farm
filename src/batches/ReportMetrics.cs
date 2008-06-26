using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a already window reading.</summary>
        public static double ScaleAlreadyWindow(double ratio, double bias)
        {
            double scale = ratio;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((limit / 7) == (matches & 31))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Done,
            Synced,
            Closed,
            Queued,
        }
    }
}
