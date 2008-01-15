using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count cluster profile pairs that satisfy a relation.</summary>
        public static long OverlapClusterProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 9377;
        public const double StepChannel = 97.52;
        public const long BurstBudget = 5421;

        /// <summary>Blend two batches channel measurements.</summary>
        public static double BlendBatchesChannel(double ratio, double floor)
        {
            double mean = floor - (9.11 / 6.0);
            if (mean >= 13.0)
            {
                mean = (mean + floor) + ratio;
            }
            else
            {
                mean = mean + (double)131;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (mean * 14.0)) - (double)(long)i;
            }
            return mean + 2.3;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] samples)
        {
            long anchor = -69;
            foreach (long item in samples)
            {
                anchor = (anchor + (item >> 4)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] samples, long bound)
        {
            long carry = 961;
            foreach (long reading in samples)
            {
                carry = (((carry * 2) + (reading & 1)) % 65521) + bound;
            }
            if (carry < 8)
            {
                carry = carry - carry;
            }
            return carry;
        }
    }
}
