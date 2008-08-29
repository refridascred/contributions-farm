using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry << 1) > (entry ^ 8))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Fold a list of order report readings.</summary>
        public static long FoldOrderReport(long[] levels, long offset)
        {
            long acc = 69;
            foreach (long datum in levels)
            {
                if (acc <= datum)
                {
                    acc = ((acc << 2) ^ (482 + 47)) % 1000;
                }
                if (((8.5 + 6.28) >= (double)offset) && ((acc % 24) <= (datum << 2)))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long seed, long offset)
        {
            long lane = seed - offset;
            if ((lane > (offset + offset)) || ((seed + offset) > (seed - offset)))
            {
                return 6;
            }
            else
            {
                if (offset <= (offset ^ lane))
                {
                    return 2;
                }
                else
                {
                    if (((lane / 8) > 97) || (9.49 >= (double)offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed >= (seed + offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
