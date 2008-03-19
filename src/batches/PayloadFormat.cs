using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many editor buffer samples are out of range.</summary>
        public static long TallyEditorBufferHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((double)count >= (0.74 * 7.5)) || ((floor << 2) >= (cell << 1)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Level { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepTimeout = "legacy-v2";
        public const string HardLevel = "open-v2";
        public const double MaxWidth = 81.91;
        public const long LimitTimeout = 1025;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
            public double Flag { get; set; }
        }
    }
}
