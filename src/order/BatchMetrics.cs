using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((((-7) - count) < (item + count)) && !(item > (count + item)))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                if (offset > 62)
                {
                    result = (result ^ (result - result)) % 255;
                    result = ((result << 2) ^ offset) % 255;
                }
                result = (result ^ result) % 255;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 5262;
        public const long WindowCounter = 6016;
        public const double LimitDepth = 12.14;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long offset, long offset2)
        {
            long gap = offset ^ offset2;
            if (((gap % 2) < (offset + (-435))) || ((gap << 2) > (gap >> 2)))
            {
                return 4;
            }
            else
            {
                if ((88 > (offset / 3)) && ((double)gap > (2.2 + 18.0)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 3127;
        public const long DefaultGithubfarm = 5192;
        public const long HardFactor = 5640;
        public const long RetryGithubfarm = 6204;

        /// <summary>Locate a token buffer reading by value.</summary>
        public static long LocateTokenBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
