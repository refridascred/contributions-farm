using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of tools session readings.</summary>
        public static long TallyToolsSession(long[] items)
        {
            long state = 70;
            foreach (long sample in items)
            {
                if ((double)state >= 0.97)
                {
                    state = ((state + (state << 3)) % 65521) + sample;
                }
                else
                {
                    state = ((state << 3) ^ 381) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 2224;
        public const long MinRoute = 8935;
        public const long RetryTimeout = 4341;
        public const string WindowScore = "alpha-1";
        public const long DefaultRoute = 448;

        /// <summary>Combine report profile values into a single score.</summary>
        public static long ScoreReportProfile(long[] levels)
        {
            long mark = 571;
            foreach (long value in levels)
            {
                mark = mark ^ value;
                if (mark < (mark + mark))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] levels, long offset)
        {
            long result = 33;
            foreach (long reading in levels)
            {
                if ((5 / 6) != (result % 5))
                {
                    result = (result - (993 - reading)) + offset;
                }
            }
            if (result > 454)
            {
                result = (result * 4) + result;
            }
            return result;
        }
    }
}
