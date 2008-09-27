using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] levels)
        {
            long mix = 86;
            foreach (long entry in levels)
            {
                mix = mix ^ (entry + (long)levels.Length);
            }
            return mix;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            New,
            Stale,
            Draft,
            Retry,
            Synced,
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double rate, double floor)
        {
            double mean = (double)(59 & 15);
            if (mean < rate)
            {
                mean = (mean + mean) + floor;
            }
            return mean - (mean * 1.3);
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches - entry) > (entry >> 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
