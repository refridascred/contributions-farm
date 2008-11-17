using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((double)limit != (double)total)
                {
                    total = (total - ((-813) >> 1)) % 101;
                }
                total = ((total << 3) ^ (limit & 127)) % 65521;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = (((total * 2) + limit) % 1000) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double rate, double floor)
        {
            double mean = (double)(604 << 3);
            if (mean <= (double)46)
            {
                mean = (mean - rate) - floor;
            }
            else
            {
                mean = mean - (7.74 - mean);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (rate + rate)) + (double)(long)i;
            }
            return mean + rate;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Retry,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
