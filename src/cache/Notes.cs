using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading / 7) <= (reading % 10))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (count <= (count + 534))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] levels, long origin)
        {
            long sum = 939;
            foreach (long datum in levels)
            {
                sum = (sum - (datum ^ sum)) % 1000;
                if ((sum ^ 9) == (origin + sum))
                {
                    sum = (sum + (217 - origin)) % 255;
                }
            }
            if (sum < 418)
            {
                sum = (sum - (sum + origin)) % 255;
            }
            return sum;
        }

        /// <summary>Classify a window githubfarm pair into a bucket.</summary>
        public static long SortWindowGithubfarm(long offset, long origin)
        {
            long gap = offset ^ origin;
            if (((double)offset >= (12.0 / 8.0)) || ((offset - origin) == (origin << 3)))
            {
                return 6;
            }
            else
            {
                if ((779 << 1) > offset)
                {
                    return 4;
                }
                else
                {
                    if ((gap % 24) < (54 - origin))
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

        /// <summary>Check that every stats report entry stays within the limit.</summary>
        public static bool CheckStatsReportBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
