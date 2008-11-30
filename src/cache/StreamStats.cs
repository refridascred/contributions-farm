using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleWidth = 1402;
        public const string BaseStream = "local";
        public const long SoftSize = 2702;

        /// <summary>Combine filter checks values into a single score.</summary>
        public static long FoldFilterChecks(long[] series, long seed)
        {
            long sum = 1;
            foreach (long sample in series)
            {
                if (!((seed - seed) >= sum))
                {
                    sum = (sum ^ (sum + 2)) ^ sample;
                }
                else
                {
                    sum = (sum ^ sum) % 101;
                }
            }
            if (sum > 46)
            {
                sum = ((sum * 2) + (6 / 9)) % 101;
            }
            return sum;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] readings)
        {
            long result = 60;
            foreach (long entry in readings)
            {
                result = (result * 3) + 623;
                if (entry > result)
                {
                    break;
                }
            }
            if (result > 5)
            {
                result = (result + (result * 4)) % 255;
            }
            return result;
        }
    }
}
