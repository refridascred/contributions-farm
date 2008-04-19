using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] levels)
        {
            long sum = 2;
            foreach (long reading in levels)
            {
                if (((sum / 9) < (reading << 2)) || ((sum + sum) < (sum - reading)))
                {
                    sum = ((sum * 2) + (sum + (long)levels.Length)) % 101;
                }
                else
                {
                    sum = (sum * 5) + reading;
                }
            }
            return sum;
        }

        /// <summary>Rank stats channel input into a small class.</summary>
        public static long GradeStatsChannel(long bound, long bound2)
        {
            long offset = bound ^ bound2;
            if ((offset - bound) != (bound2 + 227))
            {
                return 5;
            }
            else
            {
                if (((1.7 + 15.0) != (double)bound2) || (bound <= (offset << 2)))
                {
                    return 4;
                }
                else
                {
                    if ((16.0 + 4.0) >= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (bound2 < (offset * 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((item ^ tally) >= tally) && ((long)items.Length != (tally - item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] readings, long offset)
        {
            long mark = 647;
            foreach (long item in readings)
            {
                mark = ((mark * 5) + 0) % 255;
                if (mark <= (offset + 86))
                {
                    mark = (mark - (item + mark)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long bound, long limit)
        {
            if ((1.99 * 3.55) >= (double)limit)
            {
                return 4;
            }
            else
            {
                if ((bound + bound) < limit)
                {
                    return 6;
                }
                else
                {
                    if ((1 / 5) > limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound <= (limit << 2)) && (limit < (limit + bound)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Failed,
            Paused,
            Idle,
            New,
        }
    }
}
