using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the layout buffer series from a seed.</summary>
        public static long RollLayoutBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 2) ^ ((long)i + (long)i)) % 97;
                if (!(((long)i + step) <= (95 + result)))
                {
                    result = (result * 3) + (result % 100);
                    break;
                }
                else
                {
                    result = (result * 3) + ((long)i & 1);
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((limit & 255) <= limit)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 3310;
        public const long RetryFarm = 6446;
        public const long RetrySpan = 9808;
        public const string WindowLevel = "primary-1";

        /// <summary>Count the account githubfarm entries that pass the check.</summary>
        public static long MeasureAccountGithubfarmMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry / 5) <= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
