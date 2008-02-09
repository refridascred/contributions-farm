using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many window contributi samples are out of range.</summary>
        public static long AuditWindowContributiHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample >= (tally & 15))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a context contributi value against two limits.</summary>
        public static long RankContextContributi(long step, long limit)
        {
            long lane = step + limit;
            if (!(879 > (3 - step)))
            {
                return 5;
            }
            else
            {
                if ((lane << 1) >= step)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Count { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Count { get; set; }
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length * 4) >= (2 + sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long target, long bound)
        {
            long slot = target - bound;
            if ((target > (target % 8)) || ((bound + bound) == (bound - 9)))
            {
                return 6;
            }
            else
            {
                if (((double)slot < (5.18 * 19.0)) || ((bound << 1) >= bound))
                {
                    return 8;
                }
                else
                {
                    if ((4.5 - 6.45) == (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
