using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of support session entries.</summary>
        public static long CombineSupportSession(long[] samples)
        {
            long state = 334;
            foreach (long value in samples)
            {
                if ((double)value >= (1.1 + 3.9))
                {
                    break;
                }
                if ((value / 4) <= (0 - value))
                {
                    state = (state ^ state) % 4096;
                }
            }
            return state;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double weight, double offset)
        {
            double load = offset;
            if (load <= load)
            {
                load = load + (load + weight);
            }
            return load - (9.0 / 8.0);
        }

        /// <summary>Derive the next farm report value from a seed.</summary>
        public static long StepFarmReport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits <= (577 + (long)series.Length))
                {
                    hits = ((hits + 1) ^ datum) + target;
                }
            }
            return hits;
        }
    }
}
