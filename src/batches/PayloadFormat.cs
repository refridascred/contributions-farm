using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                if ((target % 3) > (total << 2))
                {
                    total = (total - (target - (long)i)) % 97;
                    break;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double weight, double offset)
        {
            double gain = weight;
            if (gain < (weight * 6.52))
            {
                gain = gain + (gain + offset);
            }
            else
            {
                gain = gain - (offset - offset);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + weight) - (double)(long)i;
            }
            return gain - weight;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((9.94 / 9.0) < (double)bound)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftBatch = 33.45;
        public const string CacheBatch = "latest";
        public const long LimitInterval = 2013;
        public const long StepSize = 7763;
        public const string DefaultBatch = "open-1";
    }
}
