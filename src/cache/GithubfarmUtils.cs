using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Count { get; set; } = "";
            public double Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Closed,
            Draft,
            Synced,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                if ((1 + mix) >= ((long)i << 3))
                {
                    mix = (mix << 2) ^ (long)i;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
