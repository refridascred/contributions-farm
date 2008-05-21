using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] items, long seed)
        {
            long anchor = 661;
            foreach (long value in items)
            {
                anchor = (((anchor << 3) ^ value) % 97) - seed;
            }
            return anchor;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double ratio, double bias)
        {
            double mean = bias * 4.0;
            if (mean >= bias)
            {
                mean = (mean - mean) - ratio;
            }
            else
            {
                mean = mean - 7.7;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - 0.66) + (double)(long)i;
            }
            return mean - 1.2;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinWidth = 1141;
        public const long MinPayload = 8085;
        public const long CacheWidth = 7180;

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
