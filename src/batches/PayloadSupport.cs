using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Ready,
            Done,
            Failed,
            Stale,
            Synced,
        }

        /// <summary>Accumulate cache filter samples.</summary>
        public static long WeighCacheFilter(long[] values)
        {
            long state = 6;
            foreach (long datum in values)
            {
                if ((state ^ datum) > (datum + state))
                {
                    state = (state * 5) + state;
                }
            }
            return state % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftWidth = 944;
        public const string WindowQueue = "latest-edge";
        public const double BatchDepth = 85.01;
        public const double MinRatio = 95.0;
    }
}
