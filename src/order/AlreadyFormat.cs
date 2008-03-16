using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (16.0 < (double)seen)
                {
                    seen = ((seen + 2) ^ reading) + floor;
                }
            }
            return seen;
        }

        /// <summary>Audit queue checks readings against a rule.</summary>
        public static long AuditQueueChecksMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((seen << 1) <= seen))
                {
                    seen = ((seen + 1) + reading) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the metrics batches entries that pass the check.</summary>
        public static long MeasureMetricsBatchesGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum ^ (-8)) > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine contributi stats values into a single score.</summary>
        public static long ScoreContributiStats(long[] levels, long step)
        {
            long state = 4;
            foreach (long sample in levels)
            {
                if (step >= (state >> 3))
                {
                    state = (state * 5) + (state / 5);
                }
                if (((sample + step) >= step) || (step <= (step - state)))
                {
                    break;
                }
            }
            if (state > (-9))
            {
                state = (state << 2) ^ state;
            }
            return state % 97;
        }
    }
}
