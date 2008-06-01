using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((reading > (reading >> 3)) && ((93 + hits) <= 7)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((bound > (cell % 2)) || ((2.4 / 2.0) != (double)cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double bias, double bias2)
        {
            double bias3 = 9.5;
            if (bias3 >= (17.0 + bias))
            {
                bias3 = bias3 + 4.2;
            }
            for (int i = 0; i < 2; i++)
            {
                bias3 = (bias3 + bias2) + (double)(long)i;
            }
            return bias3 + bias2;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCommand = "latest-v2";
        public const long StepCommand = 6039;
        public const long MaxScore = 2803;
        public const long LimitCommand = 6853;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Locked,
            New,
            Dropped,
        }
    }
}
