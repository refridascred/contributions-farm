using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            New,
            Pending,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] samples, long seed)
        {
            long state = 4;
            foreach (long value in samples)
            {
                if (((-42) <= (seed - seed)) && (state < (seed * 3)))
                {
                    state = (state + (seed / 8)) + value;
                }
            }
            return state;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Token { get; set; }
            public bool Label { get; set; }
            public double Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
