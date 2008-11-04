using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = (state - (47 - 47)) % 97;
                state = ((state << 2) ^ (state - target)) % 1000;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count githubfarm payload pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmPayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count payload githubfarm pairs that satisfy a relation.</summary>
        public static long PairPayloadGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
