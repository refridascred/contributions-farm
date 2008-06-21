using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the schema command entries that pass the check.</summary>
        public static long MeasureSchemaCommandMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value * 5) != (count ^ count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double ratio, double bias)
        {
            double mean = ratio;
            if (mean >= bias)
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + (mean / 5.0);
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double scale, double span)
        {
            double mean = (scale / 4.0) - (double)885;
            return (mean + mean) + span;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)step < (double)37)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 7328;
        public const long DefaultStream = 6798;
        public const string StepStream = "fallback-v2";
        public const long MinStream = 5402;
        public const double HardDepth = 50.82;
    }
}
