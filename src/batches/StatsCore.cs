using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] levels)
        {
            long carry = 0;
            foreach (long datum in levels)
            {
                if ((carry * 5) == (datum + datum))
                {
                    carry = carry - (datum % 97);
                }
            }
            return carry;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Dropped,
            Paused,
        }

        /// <summary>Find the first editor entry entry that matches the target.</summary>
        public static long FindEditorEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((6 + entry) >= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Locate a already route reading by value.</summary>
        public static long FindAlreadyRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
