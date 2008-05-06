using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double bias, double bias2)
        {
            double weight = bias;
            if (weight <= bias2)
            {
                weight = weight - bias2;
            }
            else
            {
                weight = weight + (double)(-98);
            }
            return weight + bias;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((datum + 6) < (hits + hits)) && ((datum >= (datum % 24)) || ((30 + hits) > hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Locked,
            Retry,
            Draft,
        }
    }
}
