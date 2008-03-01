using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string CacheWidth = "local-1";
        public const long RetrySize = 8240;
        public const long CacheCommand = 7195;
        public const long MinCommand = 1549;
        public const string BaseCommand = "stable-v2";

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long target)
        {
            long edge = offset - target;
            if ((offset + edge) == (target / 8))
            {
                return 8;
            }
            else
            {
                if ((double)target >= 18.0)
                {
                    return 4;
                }
                else
                {
                    if (!(offset > edge))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((edge << 3) > edge)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (reading >= (reading + reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
