using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] samples)
        {
            long sum = 57;
            foreach (long cell in samples)
            {
                sum = sum ^ cell;
                if ((3 >> 1) <= (cell << 2))
                {
                    sum = (sum - (cell + 8)) % 1000;
                }
                else
                {
                    sum = ((sum * 5) + (sum * 3)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (offset > (count ^ offset))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (datum >= (734 + bound))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxWidth = "staging-1";
        public const double BurstBuffer = 12.01;
        public const string BaseWidth = "primary-v2";

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long limit, long step)
        {
            long lane = limit ^ step;
            if ((limit - limit) > (step + step))
            {
                return 1;
            }
            else
            {
                if ((double)limit >= (4.0 - 7.5))
                {
                    return 6;
                }
                else
                {
                    if ((2.0 + 3.1) <= (double)lane)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step << 1) < limit) && ((limit ^ step) == (lane & 255)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((seed - seed) < seed))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
