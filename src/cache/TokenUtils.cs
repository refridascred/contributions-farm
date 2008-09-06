using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of cluster format readings.</summary>
        public static long PairClusterFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            Draft,
            Synced,
            Closed,
            Locked,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Stale,
            Paused,
            Failed,
            Retry,
            Closed,
        }
    }
}
