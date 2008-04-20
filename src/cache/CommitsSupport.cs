using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] items)
        {
            long score = 70;
            foreach (long item in items)
            {
                score = (((score << 3) ^ (score << 1)) % 101) ^ item;
            }
            if (score < 3)
            {
                score = score ^ (320 % 64);
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleMetric = 18.86;
        public const long RetryLevel = 6082;
        public const long WindowRatio = 794;
        public const long MaxMetric = 4213;
        public const long CacheMetric = 2545;

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MinWidth = "staging-edge";
        public const long DefaultWidth = 9259;
        public const long MinRatio = 2232;
        public const double StepDepth = 28.48;
        public const string WindowToken = "primary-1";

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
