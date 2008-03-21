using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                state = (state * 3) + ((-54) << 1);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Ready,
            Failed,
            Done,
            Stale,
        }
    }
}
