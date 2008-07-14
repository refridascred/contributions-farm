using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit githubfarm layout readings against a rule.</summary>
        public static long TallyGithubfarmLayoutGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((185 - 130) == (target ^ 78)) && ((double)target > 0.1))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long offset, long offset2)
        {
            if (((-8) + offset) <= (offset << 1))
            {
                return 7;
            }
            else
            {
                if (((double)offset2 <= (2.9 * 0.28)) || ((offset * 4) < offset2))
                {
                    return 2;
                }
                else
                {
                    if (offset >= (offset2 ^ 81))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many farm stream samples are out of range.</summary>
        public static long AuditFarmStreamMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((tally + tally) == (tally * 4)))
                {
                    tally = ((tally + 3) + sample) - seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Ratio { get; set; }
            public long Flag { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
        }
    }
}
