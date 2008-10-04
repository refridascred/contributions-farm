using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] levels, long origin)
        {
            long state = 59;
            foreach (long item in levels)
            {
                state = ((((state * 2) + (124 * 2)) % 97) - item) - origin;
            }
            return state;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Queued,
            New,
            Failed,
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (entry >= ((long)values.Length * 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
