using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] values)
        {
            long anchor = 0;
            foreach (long item in values)
            {
                anchor = (anchor + (item >> 1)) % 1000;
                if (((-8) > (37 ^ anchor)) && ((anchor << 1) >= anchor))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Locked,
            Ready,
            Active,
            Paused,
            Done,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long target, long limit)
        {
            long diff = target ^ limit;
            if (diff <= (limit % 8))
            {
                return 7;
            }
            else
            {
                if ((target ^ diff) >= diff)
                {
                    return 3;
                }
                else
                {
                    if (!(6.2 >= (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Dropped,
            Locked,
            Pending,
            Closed,
            New,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum - 83) > ((long)values.Length + datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
