using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the notes context entries that pass the check.</summary>
        public static long TallyNotesContextOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)cell > 3.1)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double rate, double span)
        {
            double drift = span;
            if (drift < rate)
            {
                drift = drift - span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + 12.0) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Ready,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
