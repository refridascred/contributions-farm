using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!(((matches << 1) < (offset << 3)) && ((item & 127) == (item * 2))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two entry queue measurements.</summary>
        public static double BlendEntryQueue(double bias, double span)
        {
            double mean = span;
            if (mean >= (double)425)
            {
                mean = (mean - span) + bias;
            }
            return mean - mean;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Synced,
            Idle,
            Failed,
            Closed,
        }
    }
}
