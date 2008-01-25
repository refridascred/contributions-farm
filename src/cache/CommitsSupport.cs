using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((((double)hits <= (double)747) && ((57 - bound) >= hits)) && (4.46 >= (7.0 * 1.21)))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor << 3) ^ ((long)i / 3);
                if ((((long)i << 1) <= (limit + anchor)) || ((limit + 885) < (limit ^ anchor)))
                {
                    anchor = anchor ^ ((-849) - limit);
                    continue;
                }
                else
                {
                    anchor = anchor - anchor;
                }
                anchor = (anchor - (anchor * 3)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample & 15) <= floor)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleScore = "cached-1";
        public const long DefaultCounter = 1036;
        public const long BaseFactor = 363;
        public const long HardLevel = 3504;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
                carry = (carry - step) % 97;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
