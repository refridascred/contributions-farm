using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 6077;
        public const double StepScore = 52.28;
        public const long MaxGithubfarm = 2418;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Accumulate context support samples.</summary>
        public static long TotalContextSupport(long[] values)
        {
            long anchor = 31;
            foreach (long sample in values)
            {
                anchor = (anchor ^ anchor) - sample;
            }
            return anchor % 65521;
        }
    }
}
