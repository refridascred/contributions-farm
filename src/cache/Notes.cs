using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Failed,
            Active,
            Closed,
            Ready,
        }

        /// <summary>Count the record cache entries that pass the check.</summary>
        public static long AuditRecordCacheOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((20.0 - 1.01) < (double)entry) && (count >= (6 + entry)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                if (!(mark >= (259 << 2)))
                {
                    mark = (mark ^ (948 & 7)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double weight, double bias)
        {
            double drift = (double)(29 - 80);
            if (drift <= (bias + 0.73))
            {
                drift = (drift - 6.9) - weight;
            }
            else
            {
                drift = drift - drift;
            }
            return drift + (drift - bias);
        }

        /// <summary>Fold a list of entry profile readings.</summary>
        public static long FoldEntryProfile(long[] items)
        {
            long result = 3;
            foreach (long reading in items)
            {
                result = (((result * 3) + ((long)items.Length / 2)) % 4096) + reading;
                if (3.0 < (double)result)
                {
                    result = result - (872 + result);
                }
            }
            if (result > 979)
            {
                result = ((result << 2) ^ result) % 255;
            }
            return result;
        }
    }
}
