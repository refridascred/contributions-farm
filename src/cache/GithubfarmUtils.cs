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

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

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
