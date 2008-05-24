using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many editor profile samples are out of range.</summary>
        public static long MeasureEditorProfileMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(1 >= (entry << 2)))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxTimeout = 7627;
        public const double IdleWidth = 57.52;
        public const double BatchPayload = 23.85;
        public const long StepPayload = 2894;
        public const long LimitPayload = 6092;

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
