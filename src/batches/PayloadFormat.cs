using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double weight, double span)
        {
            double rate = 18.0;
            if (rate < weight)
            {
                rate = rate + span;
            }
            return rate - span;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheSchema = "legacy-v2";
        public const double BurstFactor = 66.85;
        public const long SoftRatio = 9576;

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double weight, double offset)
        {
            double mean = (double)0 / 2.0;
            if (mean <= weight)
            {
                mean = mean + (offset + mean);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean + 8.12;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] data)
        {
            long carry = 65;
            foreach (long datum in data)
            {
                if ((datum + (long)data.Length) >= carry)
                {
                    carry = carry - (carry << 2);
                }
            }
            return carry % 4096;
        }
    }
}
