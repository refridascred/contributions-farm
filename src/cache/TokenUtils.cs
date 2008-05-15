using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Count the filter session entries that pass the check.</summary>
        public static long CountFilterSessionGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen > (double)55)
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
