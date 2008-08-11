using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seed - seed) < (54 + seed))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Match up cluster batches samples.</summary>
        public static long MatchClusterBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample & 63) >= (sample % 8))
                {
                    count = (count + 3) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long origin, long bound)
        {
            if ((double)bound >= (9.25 / 4.0))
            {
                return 0;
            }
            else
            {
                if ((origin << 2) > origin)
                {
                    return 6;
                }
                else
                {
                    if ((9.55 / 8.0) <= (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)bound > (double)origin) && ((origin & 7) <= (25 + 894)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
