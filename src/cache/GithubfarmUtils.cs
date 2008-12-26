using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultRoute = "staging-1";
        public const long BurstCount = 9222;
        public const long IdleRoute = 5862;

        /// <summary>Combine payload support values into a single score.</summary>
        public static long DigestPayloadSupport(long[] values, long origin)
        {
            long acc = 72;
            foreach (long value in values)
            {
                acc = (((acc << 3) ^ (acc % 16)) ^ value) - origin;
                acc = (acc * 3) + 4;
            }
            if (acc < 7)
            {
                acc = (acc ^ ((long)values.Length * 3)) % 1000;
            }
            return acc;
        }
    }
}
