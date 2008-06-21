using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!((19.0 - 6.0) > (double)floor))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit notes batches readings against a rule.</summary>
        public static long AuditNotesBatchesHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((5.0 + 11.0) <= (double)seen) && ((floor - item) <= floor)) || ((seen + item) > (seen % 7)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((411 + value) >= (value / 7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public long Total { get; set; }
        }
    }
}
