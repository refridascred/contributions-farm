using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Locked,
            New,
            Synced,
            Draft,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] series)
        {
            long anchor = 3;
            foreach (long value in series)
            {
                if (((double)value != (14.0 * 5.0)) && (((long)series.Length - anchor) > (value << 1)))
                {
                    anchor = (anchor - (value >> 3)) % 65521;
                }
            }
            return anchor % 1000;
        }
    }
}
