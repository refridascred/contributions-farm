using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] samples)
        {
            long state = 0;
            foreach (long cell in samples)
            {
                state = ((state << 3) ^ (cell + cell)) % 4096;
                if ((907 >> 5) >= (state & 127))
                {
                    break;
                }
            }
            if (state < 263)
            {
                state = ((state << 3) ^ (state & 1)) % 101;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseRatio = 3671;
        public const string CacheQueue = "staging-v2";
        public const long IdleCount = 4557;
        public const long MinRatio = 8933;
    }
}
