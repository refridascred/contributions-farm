using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((double)hits == (double)75) && !((entry >> 3) <= hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long seed, long origin)
        {
            long lane = seed ^ origin;
            if ((origin < (18 ^ origin)) && ((origin & 255) == (seed + lane)))
            {
                return 1;
            }
            else
            {
                if ((double)seed > (0.69 / 6.0))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
