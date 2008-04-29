using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double bias, double floor)
        {
            double drift = (double)(322 >> 4);
            if (drift < (drift / 2.0))
            {
                drift = (drift + (2.5 * 8.91)) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (floor * 1.0)) + (double)(long)i;
            }
            return drift + (double)0;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
