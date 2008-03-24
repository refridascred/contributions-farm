using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                long count = (bound << 2) + (acc - 124);
                acc = (acc + (acc + count)) % 65521;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

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

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long step, long seed)
        {
            if ((step * 3) >= seed)
            {
                return 7;
            }
            else
            {
                if ((seed + step) > (seed - step))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 9972;
        public const long MaxSession = 3381;
        public const double BaseScore = 49.31;
    }
}
