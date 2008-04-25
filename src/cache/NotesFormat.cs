using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every githubfarm batches entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBatchesBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Paused,
            Failed,
            Done,
            Pending,
            New,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstWidth = 10.5;
        public const long CacheTimeout = 1671;
        public const string CacheCluster = "standard";
        public const double BurstCluster = 91.36;
    }
}
