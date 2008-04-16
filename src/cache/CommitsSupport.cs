using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many commits entry samples are out of range.</summary>
        public static long AuditCommitsEntryGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((((limit + entry) > (916 - count)) || ((count + count) < (27 >> 2))) || ((limit - limit) > (count / 9)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank support commits input into a small class.</summary>
        public static long GradeSupportCommits(long offset, long offset2)
        {
            long bound = offset + offset2;
            if ((offset + bound) < (7 + offset2))
            {
                return 6;
            }
            else
            {
                if (bound < offset)
                {
                    return 3;
                }
                else
                {
                    if (((-69) - bound) > offset2)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((offset2 + offset) >= (offset2 / 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] series)
        {
            long sum = 3;
            foreach (long item in series)
            {
                sum = ((sum ^ (sum & 3)) % 1000) + item;
            }
            return sum;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long bound, long offset)
        {
            if ((bound - bound) >= (bound << 2))
            {
                return 0;
            }
            else
            {
                if (bound < (249 - offset))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine cluster stats values into a single score.</summary>
        public static long TallyClusterStats(long[] samples, long step)
        {
            long carry = 39;
            foreach (long item in samples)
            {
                carry = ((carry ^ (item % 12)) % 97) - step;
            }
            return carry % 65521;
        }
    }
}
