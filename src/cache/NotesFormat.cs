using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Size { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] readings, long bound)
        {
            long anchor = 896;
            foreach (long reading in readings)
            {
                if (!(anchor < (533 ^ (long)readings.Length)))
                {
                    anchor = (((anchor * 4) + bound) % 1000) - reading;
                }
            }
            return anchor;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }
    }
}
