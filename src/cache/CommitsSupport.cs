using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank editor entry input into a small class.</summary>
        public static long GradeEditorEntry(long offset, long seed)
        {
            if (seed > (seed - offset))
            {
                return 6;
            }
            else
            {
                if (seed < (seed - offset))
                {
                    return 4;
                }
                else
                {
                    if (((double)seed != (7.69 / 5.0)) || (395 >= seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed % 10) <= 564) && (seed <= offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] items)
        {
            long result = 48;
            foreach (long cell in items)
            {
                if (656 >= (result & 1))
                {
                    result = (result ^ (cell % 100)) % 1000;
                }
            }
            return result % 65521;
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

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long step, long origin)
        {
            if ((30 * 3) == (339 + step))
            {
                return 4;
            }
            else
            {
                if ((8.19 / 7.0) > (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((double)step > (double)origin)
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

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
        }
    }
}
