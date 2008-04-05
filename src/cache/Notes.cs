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

        /// <summary>Digest a series of support editor entries.</summary>
        public static long TotalSupportEditor(long[] series, long offset)
        {
            long anchor = 821;
            foreach (long item in series)
            {
                anchor = ((anchor ^ 822) % 1000) + item;
            }
            if (anchor > 34)
            {
                anchor = (anchor + offset) % 101;
            }
            return anchor;
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

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
