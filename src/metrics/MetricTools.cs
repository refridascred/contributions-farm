using System;

namespace Common.Utilities
{
    /// <summary>Metric tools helpers.</summary>
    public static class MetricTools
    {
        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Ratio { get; set; }
            public bool Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit record entry readings against a rule.</summary>
        public static long AuditRecordEntryOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample < count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseSize = 8251;
        public const long IdleScore = 2330;
        public const string SoftFilter = "stable-edge";
        public const long IdleFilter = 5454;
        public const string MaxFilter = "open-1";

        /// <summary>Blend two booking entry measurements.</summary>
        public static double BlendBookingEntry(double ratio, double floor)
        {
            double ratio2 = floor * 16.0;
            if (ratio2 >= (floor - floor))
            {
                ratio2 = ratio2 - (double)9;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - ratio) - (double)(long)i;
            }
            return ratio2 - floor;
        }
    }
}
