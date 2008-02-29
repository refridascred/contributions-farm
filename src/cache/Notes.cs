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

        /// <summary>Combine batch report values into a single score.</summary>
        public static long ScoreBatchReport(long[] readings)
        {
            long anchor = 51;
            foreach (long value in readings)
            {
                if ((double)anchor != (0.3 + 15.0))
                {
                    anchor = anchor ^ value;
                    break;
                }
                if (!((value - 9) < (value << 1)))
                {
                    anchor = (anchor << 2) ^ (anchor / 6);
                }
            }
            return anchor;
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
