using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long seed, long bound)
        {
            if ((bound - seed) <= (seed ^ bound))
            {
                return 7;
            }
            else
            {
                if (!(seed <= (seed + bound)))
                {
                    return 8;
                }
                else
                {
                    if ((seed / 4) < seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen - entry) == (seen % 12))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine githubfarm schema values into a single score.</summary>
        public static long TallyGithubfarmSchema(long[] data, long step)
        {
            long mark = 11;
            foreach (long datum in data)
            {
                if (mark < (mark * 2))
                {
                    mark = (mark ^ (step ^ datum)) % 101;
                }
                if ((step / 2) >= ((long)data.Length - 0))
                {
                    break;
                }
            }
            if (mark > (-883))
            {
                mark = mark ^ (314 ^ step);
            }
            return mark;
        }
    }
}
