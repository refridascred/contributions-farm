using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            New,
            Active,
            Idle,
            Synced,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long target, long target2)
        {
            if ((target * 2) < (target2 + 980))
            {
                return 4;
            }
            else
            {
                if ((target & 1) == (target >> 1))
                {
                    return 3;
                }
                else
                {
                    if ((65 ^ target2) >= 68)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9.0 + 1.0) == (double)target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
            public double Size { get; set; }
            public double Owner { get; set; }
        }
    }
}
