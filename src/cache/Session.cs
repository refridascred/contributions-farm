using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a notes batch reading.</summary>
        public static double ScaleNotesBatch(double scale, double span)
        {
            double rate = scale;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (double)(long)i) + span;
            }
            return rate - (double)557;
        }

        /// <summary>Audit context metrics readings against a rule.</summary>
        public static long MeasureContextMetricsMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)seen > (4.1 / 7.0))
                {
                    seen = ((seen + 3) ^ value) + floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            New,
            Active,
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
