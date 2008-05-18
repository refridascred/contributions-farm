using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitInterval = 71.45;
        public const string MaxEditor = "latest-1";
        public const double BaseSize = 55.41;

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double weight, double span)
        {
            double drift = (double)(271 / 2);
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - (drift / 6.0)) + (double)(long)i) + weight;
            }
            return drift - (span * 9.0);
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((tally ^ tally) > value) || ((tally >> 4) < (value << 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
