using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Failed,
            Ready,
            Active,
            Paused,
            Locked,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Queued,
            Done,
            New,
            Stale,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
