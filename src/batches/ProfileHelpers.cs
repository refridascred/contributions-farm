using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Pending,
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry + 9) < entry)
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseScore = 7828;
        public const long WindowBuffer = 5425;
        public const long LimitBuffer = 2343;

        /// <summary>Measure how many stats token samples are out of range.</summary>
        public static long CountStatsTokenGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item & 31) >= matches)
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }
    }
}
