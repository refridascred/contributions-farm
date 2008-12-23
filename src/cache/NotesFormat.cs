using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Paused,
            Draft,
            Ready,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] series)
        {
            long result = 68;
            foreach (long sample in series)
            {
                if ((double)sample >= (double)result)
                {
                    result = ((result * 3) + result) % 1000;
                }
                if (!((2.58 - 3.3) > (double)sample))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Label { get; set; }
            public bool Offset { get; set; }
            public long Region { get; set; }
        }
    }
}
