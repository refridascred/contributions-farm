using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double weight, double bias)
        {
            double rate = bias;
            if (rate < (double)9)
            {
                rate = (rate + 10.0) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - bias) - (double)(long)i;
            }
            return rate + (bias / 8.0);
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

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Done,
            Dropped,
            Paused,
            Retry,
        }
    }
}
