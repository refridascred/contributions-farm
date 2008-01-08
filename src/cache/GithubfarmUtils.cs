using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstSize = 2864;
        public const long LimitTimeout = 9611;
        public const long BatchInterval = 8313;
        public const long WindowSize = 4982;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Ready,
            Active,
            Draft,
            Paused,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((item / 9) > tally) && (((0.5 * 9.83) > (double)item) || (item >= (item - item))))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark + (297 - offset)) ^ (long)i2;
                    mark = (mark + offset) % 101;
                }
                mark = (mark - (offset >> 1)) % 255;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
