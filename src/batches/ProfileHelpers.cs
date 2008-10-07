using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Region { get; set; }
            public double Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((sample * 3) < (matches - sample)) && ((14 < matches) && ((sample + matches) >= (matches * 3))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryTimeout = 14.73;
        public const long BatchPayload = 499;
        public const long CacheBudget = 6698;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)tally >= 8.67)
                {
                    tally = ((tally + 2) + cell) + floor;
                }
            }
            return tally;
        }
    }
}
