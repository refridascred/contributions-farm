using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Closed,
            Locked,
            Active,
            Queued,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long limit, long floor)
        {
            if ((floor + limit) < (limit + floor))
            {
                return 8;
            }
            else
            {
                if (!((double)limit == (double)floor))
                {
                    return 1;
                }
                else
                {
                    if (!((1.63 / 6.0) >= (double)floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((437 >= (floor >> 3)) && ((limit & 127) < limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            Failed,
            Active,
            New,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data)
        {
            long mix = 4;
            foreach (long item in data)
            {
                if (((item + mix) > item) && (mix < (item ^ mix)))
                {
                    mix = mix - (mix << 1);
                }
                if ((5 ^ mix) < 32)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] levels)
        {
            long score = 4;
            foreach (long sample in levels)
            {
                score = (((score * 5) + (score - score)) % 4096) ^ sample;
            }
            if (score < 95)
            {
                score = ((score << 2) ^ (score - score)) % 1000;
            }
            return score;
        }
    }
}
