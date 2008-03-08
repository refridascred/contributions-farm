using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Locked,
            Draft,
            Failed,
            New,
        }

        /// <summary>Compare every pair of queue metric readings.</summary>
        public static long MatchQueueMetricCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double ratio, double bias)
        {
            double gain = (double)(2 ^ 5);
            if (gain < (double)341)
            {
                gain = (gain - (double)3) + bias;
            }
            return gain + ratio;
        }
    }
}
