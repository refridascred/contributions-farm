using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultLevel = 6235;
        public const double IdleBatches = 67.3;
        public const string BatchBatches = "cached";
        public const long DefaultScore = 2544;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double offset)
        {
            double rate = (11.0 + offset) - (0.25 + offset);
            if (rate < (weight + rate))
            {
                rate = rate + (1.6 - rate);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + (rate / 6.0);
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry > 16.0)
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
