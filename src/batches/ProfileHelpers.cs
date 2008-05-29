using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many checks batch samples are out of range.</summary>
        public static long MeasureChecksBatchHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches + seed) >= (matches + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheDepth = 3407;
        public const double LimitNotes = 89.9;
        public const double MaxTimeout = 66.3;

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Synced,
            Active,
            Locked,
            Pending,
        }

        /// <summary>Check that every already support entry stays within the limit.</summary>
        public static bool ValidateAlreadySupportRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
