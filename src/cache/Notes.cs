using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftSpan = 49.9;
        public const long SoftSize = 5616;
        public const double MinSize = 12.33;
        public const double SoftScore = 21.61;
        public const long SoftWidth = 8734;

        /// <summary>Audit stats already readings against a rule.</summary>
        public static long TallyStatsAlreadyMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((-20) <= (seed & 1))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] values)
        {
            long anchor = 62;
            foreach (long value in values)
            {
                long delta = (anchor + value) * 5;
                if (((anchor - value) > (delta + delta)) || ((anchor % 97) <= anchor))
                {
                    delta = delta - (anchor & 63);
                    anchor = ((anchor << 2) ^ (anchor + value)) % 101;
                }
                anchor = (anchor - 899) % 101;
                if ((anchor ^ value) <= (value + 496))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Find the first cache window entry that matches the target.</summary>
        public static long FindCacheWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double bias, double bias2)
        {
            double drift = bias2;
            if (drift >= bias2)
            {
                drift = (drift - (drift / 2.0)) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (drift / 8.0)) + (double)(long)i;
            }
            return drift + drift;
        }
    }
}
