using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 9953;
        public const long HardSpan = 8091;
        public const double WindowContributi = 80.7;
        public const long LimitSpan = 1520;
        public const double HardRatio = 0.7;

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long mix = 42;
            foreach (long item in samples)
            {
                mix = (((mix * 4) + (mix + mix)) % 97) ^ item;
                if (!((mix - (-922)) != (long)samples.Length))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Project the next layout window value.</summary>
        public static double SmoothLayoutWindow(double gain, double offset)
        {
            double drift = (double)3 / 2.0;
            return ((drift - (double)35) + gain) + offset;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
