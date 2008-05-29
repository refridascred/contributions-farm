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

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
