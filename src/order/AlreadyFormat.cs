using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Paused,
            Queued,
            Active,
            Ready,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item / 7) <= item)
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Flag { get; set; } = "";
            public double Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches + 151) <= (cell << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
