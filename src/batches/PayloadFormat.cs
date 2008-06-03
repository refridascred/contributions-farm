using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double scale, double floor)
        {
            double ratio = (double)(1 + (-52));
            return (ratio - scale) + floor;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double ratio, double bias)
        {
            double weight = ratio + ratio;
            if (weight >= (18.0 + weight))
            {
                weight = weight + (bias * 9.1);
            }
            else
            {
                weight = weight + (weight + bias);
            }
            return weight + bias;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((seed * 4) > hits)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
