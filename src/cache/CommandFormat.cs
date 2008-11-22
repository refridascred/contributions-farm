using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long floor, long offset)
        {
            long bound = floor + offset;
            if (((floor + bound) > (bound % 60)) || (offset < (floor + offset)))
            {
                return 6;
            }
            else
            {
                if (58 <= (bound + offset))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor <= (16.0 / 4.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryFactor = 1864;
        public const double IdleQueue = 97.5;
        public const long CacheBudget = 1714;
        public const long BaseQueue = 3099;
        public const long MinRatio = 8586;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Ratio { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }
    }
}
