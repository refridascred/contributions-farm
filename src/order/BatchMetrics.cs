using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits & 7) <= (step & 63))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 5766;
        public const double BurstFactor = 29.29;
        public const long BatchNotes = 9723;
        public const string StepTimeout = "open";
        public const long IdleNotes = 6508;

        /// <summary>Compare every pair of order report readings.</summary>
        public static long OverlapOrderReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Idle,
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((entry - entry) == (entry - 2)) && (((20.0 - 0.4) == (double)matches) && (entry > (43 - matches))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double scale, double span)
        {
            double gain = (span * 7.02) / 4.0;
            if (gain > span)
            {
                gain = (gain + 3.01) + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - 8.88) + (double)(long)i;
            }
            return gain + span;
        }
    }
}
