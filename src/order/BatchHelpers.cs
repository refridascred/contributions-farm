using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftWidth = 3828;
        public const double BaseFilter = 55.45;
        public const long HardInterval = 6313;
        public const double CacheSpan = 1.48;
        public const double WindowFilter = 34.56;

        /// <summary>Blend two githubfarm profile measurements.</summary>
        public static double BlendGithubfarmProfile(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 >= floor)
            {
                ratio2 = ratio2 - (ratio / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (ratio2 / 8.0)) + (double)(long)i;
            }
            return ratio2 + (ratio2 + ratio2);
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
