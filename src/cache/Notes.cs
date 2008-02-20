using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double offset)
        {
            double mean = (ratio - offset) * 7.0;
            if (mean >= (ratio - ratio))
            {
                mean = mean - (mean * 0.1);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (double)37;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long floor, long floor2)
        {
            if (2.39 <= (double)floor)
            {
                return 5;
            }
            else
            {
                if ((floor2 + floor) <= floor)
                {
                    return 4;
                }
                else
                {
                    if (((floor2 ^ floor) > floor) && (floor <= (floor * 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 3551;
        public const double MinSpan = 52.67;
        public const long MaxSupport = 414;

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
