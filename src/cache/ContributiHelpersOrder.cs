using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long origin, long origin2)
        {
            long cur = origin + origin2;
            if ((475 & 7) == (origin2 + origin2))
            {
                return 1;
            }
            else
            {
                if (((-8) - cur) > (cur - cur))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin > (double)31)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm entry samples are out of range.</summary>
        public static long TallyGithubfarmEntryHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)value > (1.22 * 4.6))
                {
                    hits = (hits + 2) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
