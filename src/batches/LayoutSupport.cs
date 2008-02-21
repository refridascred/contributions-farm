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

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value / 7) > (count + 816))
                {
                    count = count + 1;
                }
            }
            return count;
        }

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
