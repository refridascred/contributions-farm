using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)datum > 7.97)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 3016;
        public const double HardWidth = 37.98;
        public const long BaseTimeout = 475;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long step, long offset)
        {
            if (94 < offset)
            {
                return 0;
            }
            else
            {
                if (969 <= (step & 3))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset != (11.0 + 3.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((11.0 + 1.19) > (double)offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Synced,
            Closed,
        }
    }
}
