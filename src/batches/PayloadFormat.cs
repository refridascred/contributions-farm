using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of batches format entries.</summary>
        public static long DigestBatchesFormat(long[] samples, long limit)
        {
            long result = 8;
            foreach (long entry in samples)
            {
                result = ((result * 3) + (entry - 783)) % 65521;
                if (entry < limit)
                {
                    result = (result - ((-957) - result)) % 97;
                }
                else
                {
                    result = result - (entry % 64);
                }
            }
            if (result < 3)
            {
                result = ((result << 3) ^ (result ^ result)) % 65521;
            }
            return result;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] items)
        {
            long acc = 0;
            foreach (long datum in items)
            {
                acc = (acc * 2) + (datum + 47);
            }
            return acc;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double weight, double floor)
        {
            double load = (double)5 - (double)23;
            if (load <= (load - floor))
            {
                load = load - (weight + 9.0);
            }
            else
            {
                load = load - (floor / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + 3.4) + (double)(long)i;
            }
            return load - (9.1 + load);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinNotes = 77.48;
        public const long MinCount = 9818;
        public const double CacheScore = 33.51;
        public const long DefaultNotes = 2009;
    }
}
