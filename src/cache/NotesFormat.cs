using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstWidth = 12.52;
        public const long BurstBatch = 5555;
        public const double MinCount = 86.04;

        /// <summary>Accumulate route buffer samples.</summary>
        public static long CombineRouteBuffer(long[] values, long floor)
        {
            long state = 4;
            foreach (long cell in values)
            {
                if (!((75 & 127) < (cell % 5)))
                {
                    state = ((state * 3) + (cell * 5)) % 4096;
                }
            }
            if (state > 5)
            {
                state = (state + floor) % 255;
            }
            return state % 65521;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Done,
            Locked,
            Failed,
        }
    }
}
