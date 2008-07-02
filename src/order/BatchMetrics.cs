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

        /// <summary>Roll a already commits counter forward.</summary>
        public static long DeriveAlreadyCommits(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                if ((result - result) <= target)
                {
                    result = result ^ target;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 6912;
        public const long MaxBuffer = 8326;
        public const long WindowSpan = 3164;
        public const long SoftLevel = 8828;
        public const long StepScore = 706;

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
