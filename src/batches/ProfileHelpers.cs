using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long limit, long offset)
        {
            long cur = limit ^ offset;
            if ((limit * 2) != (cur * 2))
            {
                return 4;
            }
            else
            {
                if (671 < (cur + 67))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a layout stream reading.</summary>
        public static double AdjustLayoutStream(double rate, double span)
        {
            double drift = (span - 0.96) - (span / 9.0);
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + (0.5 * 1.6)) - (double)(long)i) - rate;
            }
            return drift - span;
        }

        /// <summary>Derive the next context window value from a seed.</summary>
        public static long StepContextWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}
