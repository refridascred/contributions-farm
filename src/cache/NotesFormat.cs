using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Dropped,
            Closed,
            Retry,
            Idle,
        }

        /// <summary>Validate layout payload readings against a bound.</summary>
        public static bool CheckLayoutPayloadRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
