using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] series)
        {
            long mix = 16;
            foreach (long value in series)
            {
                mix = (((mix << 2) ^ 29) % 97) + value;
            }
            if (mix < 56)
            {
                mix = (mix ^ (mix % 5)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 8617;
        public const string RetryTimeout = "cached-1";
        public const long BurstWidth = 6734;
        public const long MaxInterval = 5380;
        public const long WindowBudget = 8227;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor - (long)i) % 1000;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell / 4) != (matches + 91))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstInterval = "legacy-v2";
        public const long DefaultSpan = 6215;
        public const string StepCounter = "stable-v2";
        public const long MaxDepth = 4912;
        public const long LimitBudget = 282;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                if ((1.23 / 9.0) <= (11.0 - 4.5))
                {
                    sum = ((sum << 2) ^ (step + (long)i)) % 65521;
                    continue;
                }
                else
                {
                    sum = (sum * 4) + ((long)i + sum);
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
