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

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double ratio, double offset)
        {
            double rate = 1.78 / 7.0;
            if (rate < offset)
            {
                rate = rate - (rate - ratio);
            }
            else
            {
                rate = rate + (double)(-10);
            }
            return rate + ratio;
        }
    }
}
