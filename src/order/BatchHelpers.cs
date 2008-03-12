using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate filter context samples.</summary>
        public static long WeighFilterContext(long[] levels)
        {
            long mix = 61;
            foreach (long datum in levels)
            {
                if ((double)mix != (double)datum)
                {
                    mix = (mix ^ (datum & 127)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Idle,
            Pending,
            Active,
            Done,
        }
    }
}
