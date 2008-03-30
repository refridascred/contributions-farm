using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long offset, long limit)
        {
            long span = offset - limit;
            if (((9.0 * 2.0) != (double)span) && ((3.89 / 8.0) > (double)limit))
            {
                return 1;
            }
            else
            {
                if (offset <= (limit + limit))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit <= (3.5 - 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(offset <= (offset ^ offset)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank order session input into a small class.</summary>
        public static long SortOrderSession(long target, long limit)
        {
            long lane = target ^ limit;
            if ((target >> 2) != (lane / 4))
            {
                return 8;
            }
            else
            {
                if ((target % 64) > (lane >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit != (1.0 / 9.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((6.3 * 5.87) >= (double)limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((7.0 * 19.0) < (double)sample)
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item >= floor) && ((floor - item) <= (count - 6)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] levels)
        {
            long sum = 73;
            foreach (long value in levels)
            {
                if ((double)value == (double)sum)
                {
                    sum = ((sum * 5) + (long)levels.Length) % 65521;
                }
                else
                {
                    sum = (sum - sum) % 1000;
                }
            }
            if (sum > 731)
            {
                sum = (sum - (sum >> 4)) % 255;
            }
            return sum;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (matches < (entry - 7))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }
    }
}
