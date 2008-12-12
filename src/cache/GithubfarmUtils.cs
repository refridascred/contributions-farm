using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((target + sample) != (sample << 1)) && ((tally % 8) <= (sample - tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long limit, long floor)
        {
            long delta = limit + floor;
            if (floor > ((-809) - floor))
            {
                return 1;
            }
            else
            {
                if (((2 & 7) <= floor) && ((2 + delta) < (45 - limit)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Label { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
