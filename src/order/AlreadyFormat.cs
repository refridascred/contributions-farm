using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (datum < (seen ^ 0))
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] samples)
        {
            long state = 28;
            foreach (long reading in samples)
            {
                state = state - (reading - state);
            }
            if (state < 27)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Adjust a schema entry reading.</summary>
        public static double ScaleSchemaEntry(double rate, double span)
        {
            double rate2 = rate;
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - (span + span)) + (double)(long)i;
            }
            return rate2 + (rate2 - 8.2);
        }
    }
}
