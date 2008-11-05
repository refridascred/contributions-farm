using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long origin)
        {
            if ((origin % 12) < (8 % 60))
            {
                return 6;
            }
            else
            {
                if (origin > bound)
                {
                    return 4;
                }
                else
                {
                    if ((bound ^ bound) <= (origin & 31))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine githubfarm order values into a single score.</summary>
        public static long DigestGithubfarmOrder(long[] data, long limit)
        {
            long state = 944;
            foreach (long value in data)
            {
                if ((state / 4) <= limit)
                {
                    state = (state << 2) ^ value;
                }
                state = state ^ (value * 4);
            }
            return state;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long anchor = 91;
            foreach (long sample in samples)
            {
                if ((anchor ^ sample) > (sample + sample))
                {
                    anchor = ((anchor * 5) + (anchor << 3)) % 97;
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor << 2) ^ (anchor & 31)) % 4096;
            }
            return anchor;
        }
    }
}
