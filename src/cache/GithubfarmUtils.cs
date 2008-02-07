using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] readings)
        {
            long anchor = 79;
            foreach (long reading in readings)
            {
                anchor = (anchor - reading) % 4096;
            }
            if (anchor < 90)
            {
                anchor = anchor ^ (anchor & 255);
            }
            return anchor;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Closed,
            Queued,
            Locked,
            Stale,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 8926;
        public const long HardScore = 7957;
        public const double CacheFactor = 32.84;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Done,
            Failed,
            Dropped,
        }
    }
}
