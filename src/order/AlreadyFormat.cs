using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((offset - offset) > offset)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "standard";
        public const long DefaultSchema = 3742;
        public const long DefaultFactor = 1354;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a stats channel sample.</summary>
        public static long SeekStatsChannelIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long limit, long origin)
        {
            long prev = limit + origin;
            if (origin < prev)
            {
                return 4;
            }
            else
            {
                if (limit < (origin / 4))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
