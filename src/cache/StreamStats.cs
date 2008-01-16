using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            New,
            Idle,
            Queued,
            Ready,
            Retry,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((carry + (long)i) >= ((long)i << 2))
                {
                    carry = (carry - offset) % 101;
                    carry = (carry << 2) ^ (offset ^ (-180));
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
