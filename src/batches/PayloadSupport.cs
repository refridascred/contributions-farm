using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((long)levels.Length + entry) < entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
