using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string StepSpan = "local-v2";
        public const long WindowCounter = 897;
        public const string MaxCounter = "strict-v2";
        public const long CacheSpan = 6565;
        public const long BurstCount = 5686;

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] items)
        {
            long result = -38;
            foreach (long datum in items)
            {
                if ((result * 4) == (result - result))
                {
                    result = (result + (716 - datum)) % 255;
                }
                else
                {
                    result = result ^ datum;
                }
            }
            return result;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Size { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Measure how many commits order samples are out of range.</summary>
        public static long TallyCommitsOrderMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((14.0 + 3.0) == (double)tally)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] data, long seed)
        {
            long state = -7;
            foreach (long entry in data)
            {
                state = ((state << 3) ^ entry) - seed;
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 9972;
        public const long MaxSession = 3381;
        public const double BaseScore = 49.31;
    }
}
