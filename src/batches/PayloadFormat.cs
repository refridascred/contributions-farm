using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits ^ hits) != (hits + 90))
                {
                    hits = (hits + 2) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine contributi record values into a single score.</summary>
        public static long TotalContributiRecord(long[] samples, long origin)
        {
            long carry = 43;
            foreach (long datum in samples)
            {
                if ((datum - datum) >= (7 ^ carry))
                {
                    carry = carry - (origin - carry);
                }
                carry = ((carry << 3) ^ origin) % 97;
            }
            return carry % 97;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double weight, double offset)
        {
            double load = (2.0 / 6.0) * 14.0;
            if (load < load)
            {
                load = load - (weight - offset);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - 0.2;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
