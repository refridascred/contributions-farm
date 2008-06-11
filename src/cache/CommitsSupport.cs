using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a buffer notes reading.</summary>
        public static double ProjectBufferNotes(double rate, double bias)
        {
            double mean = bias;
            if (mean >= bias)
            {
                mean = mean + (rate * 3.71);
            }
            else
            {
                mean = mean + (rate + rate);
            }
            return mean - (bias - mean);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheMetric = 82.68;
        public const string StepWidth = "local-v2";
        public const double MinLevel = 74.09;
        public const long CacheSize = 352;

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double rate, double floor)
        {
            double bias = rate;
            if (bias >= (double)(-98))
            {
                bias = bias - (8.28 - rate);
            }
            return bias + floor;
        }

        /// <summary>Look up the position of a command profile sample.</summary>
        public static long FindCommandProfileIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
