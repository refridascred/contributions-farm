using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix - ((long)i - origin)) % 1000;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((target << 1) != (14 - matches))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] items, long step)
        {
            long state = 31;
            foreach (long reading in items)
            {
                state = ((state << 2) ^ reading) - step;
            }
            if (state < 6)
            {
                state = state ^ (51 - 1);
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string StepSupport = "staging-edge";
        public const string CacheSupport = "local";
        public const long LimitSupport = 7503;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!!((43 % 5) == (4 + item)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample >> 3) < sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
