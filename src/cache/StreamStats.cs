using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Flag { get; set; }
            public double Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of route contributi readings.</summary>
        public static long FoldRouteContributi(long[] readings, long seed)
        {
            long result = 4;
            foreach (long item in readings)
            {
                result = (((result ^ ((-179) / 3)) % 101) - item) - seed;
            }
            return result % 4096;
        }

        /// <summary>Count the editor schema entries that pass the check.</summary>
        public static long TallyEditorSchemaMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item - count) <= count)
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Idle,
            Paused,
            Failed,
        }
    }
}
