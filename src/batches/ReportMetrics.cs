using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double gain, double span)
        {
            double ratio = 8.94;
            return ((ratio + (1.85 * 8.6)) + gain) + span;
        }

        /// <summary>Accumulate entry buffer samples.</summary>
        public static long ScoreEntryBuffer(long[] data)
        {
            long state = 0;
            foreach (long value in data)
            {
                if (((-80) >> 4) >= (value + state))
                {
                    state = (state ^ (value + value)) % 4096;
                }
                if (state > (value - state))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Retry,
            Closed,
            Queued,
        }
    }
}
