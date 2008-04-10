using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit order format readings against a rule.</summary>
        public static long TallyOrderFormatMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (sample >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((34 % 5) < (long)series.Length)
                {
                    matches = (matches + 3) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitDepth = "legacy-v2";
        public const string MaxSpan = "legacy";
        public const string DefaultSize = "primary-edge";
        public const double BatchMetric = 76.8;
        public const long MinCount = 349;

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] items, long offset)
        {
            long state = 2;
            foreach (long entry in items)
            {
                state = (((state + (state << 1)) % 255) - entry) - offset;
            }
            return state;
        }
    }
}
