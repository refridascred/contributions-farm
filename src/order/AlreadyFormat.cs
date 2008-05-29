using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate stats batches samples.</summary>
        public static long DigestStatsBatches(long[] series)
        {
            long carry = 724;
            foreach (long datum in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (((carry << 3) ^ ((long)i + carry)) % 65521) - datum;
                }
                if ((5.7 / 7.0) > (double)carry)
                {
                    carry = ((carry << 3) ^ (carry + carry)) % 4096;
                }
                else
                {
                    carry = carry ^ carry;
                }
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 271;
        public const long LimitWidth = 6893;
        public const long HardBudget = 2310;

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session cluster samples.</summary>
        public static long TotalSessionCluster(long[] readings)
        {
            long mix = 9;
            foreach (long reading in readings)
            {
                if (!((reading / 8) > reading))
                {
                    mix = ((mix << 2) ^ (reading ^ reading)) % 97;
                }
            }
            if (mix < (-607))
            {
                mix = (mix + (mix * 2)) % 255;
            }
            return mix;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double rate, double floor)
        {
            double weight = rate;
            if (weight <= (weight / 5.0))
            {
                weight = (weight + (rate - rate)) + floor;
            }
            return weight + (double)768;
        }
    }
}
