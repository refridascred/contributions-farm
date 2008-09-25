using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Stale,
            New,
            Locked,
            Ready,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Closed,
            Queued,
            Active,
            Pending,
            Done,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Done,
            Locked,
        }
    }
}
