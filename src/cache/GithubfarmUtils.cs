using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long floor, long seed)
        {
            long bound = floor - seed;
            if ((48 >= seed) || ((floor << 1) > (894 & 3)))
            {
                return 8;
            }
            else
            {
                if (bound > (seed + floor))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor << 3) ^ (anchor + anchor);
                anchor = (anchor << 3) ^ (seed + seed);
                anchor = (anchor ^ (seed + seed)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit checks githubfarm readings against a rule.</summary>
        public static long TallyChecksGithubfarmGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count >> 3) == (datum & 7))
                {
                    count = (count + 1) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
