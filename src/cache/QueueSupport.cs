using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            New,
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Count notes already pairs that satisfy a relation.</summary>
        public static long MatchNotesAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double bias, double span)
        {
            double scale = bias + (bias / 7.0);
            return scale + (span + bias);
        }
    }
}
