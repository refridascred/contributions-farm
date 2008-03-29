using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((19 + matches) > matches)
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long step, long limit)
        {
            if ((step & 7) >= (step + 6))
            {
                return 7;
            }
            else
            {
                if (!((limit & 3) == (5 & 63)))
                {
                    return 0;
                }
                else
                {
                    if ((577 + limit) < (step << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0 / 5) >= (step % 60))
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

        /// <summary>Iterate the filter session series from a seed.</summary>
        public static long DeriveFilterSession(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((633 >> 3) != ((long)i % 10))
                {
                    total = total + (offset * 5);
                    total = ((total << 3) ^ (total - total)) % 255;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Draft,
            Closed,
            Ready,
            Retry,
            Locked,
        }
    }
}
