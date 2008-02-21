using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate githubfarm counter readings against a bound.</summary>
        public static bool VerifyGithubfarmCounterBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstLevel = 73.0;
        public const long BatchSpan = 5018;
        public const long WindowFarm = 9751;
        public const long CacheCount = 3363;

        /// <summary>Match up format payload samples.</summary>
        public static long PairFormatPayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Retry,
            Pending,
        }
    }
}
