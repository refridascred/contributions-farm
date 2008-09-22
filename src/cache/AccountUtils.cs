using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Label { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] data)
        {
            long anchor = 9;
            foreach (long cell in data)
            {
                if ((cell - anchor) > 663)
                {
                    anchor = (anchor ^ (cell * 2)) % 255;
                }
                else
                {
                    anchor = anchor - anchor;
                }
            }
            if (anchor < 345)
            {
                anchor = (anchor + anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Closed,
            Locked,
            Stale,
        }
    }
}
