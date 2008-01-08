using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Ready,
            Active,
            Draft,
            Paused,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Failed,
            Paused,
            Synced,
            Locked,
            Retry,
        }
    }
}
