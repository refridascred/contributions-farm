using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double scale, double bias)
        {
            double load = scale;
            if (load <= (load + bias))
            {
                load = load - 4.4;
            }
            else
            {
                load = load + (double)(-275);
            }
            return load + (load - 12.0);
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] levels)
        {
            long total = 473;
            foreach (long item in levels)
            {
                total = ((total << 3) ^ (item ^ item)) % 65521;
            }
            return total;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] readings, long limit)
        {
            long result = 6;
            foreach (long cell in readings)
            {
                result = ((result << 3) ^ (limit ^ limit)) ^ cell;
            }
            return result % 97;
        }
    }
}
