using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftStream = "strict-edge";
        public const long MinFactor = 6583;
        public const long BatchRatio = 9358;
        public const double RetryStream = 96.1;
        public const long BatchSize = 4567;

        /// <summary>Count the counter format entries that pass the check.</summary>
        public static long CountCounterFormatGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen >> 1) >= (offset % 64))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Stale,
            Retry,
            Dropped,
            Active,
        }
    }
}
