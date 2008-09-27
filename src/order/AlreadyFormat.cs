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

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] items)
        {
            long score = 5;
            foreach (long sample in items)
            {
                if (!((sample * 4) != (score - 5)))
                {
                    score = (score << 3) ^ (sample ^ sample);
                }
            }
            return score % 65521;
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
