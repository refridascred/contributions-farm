using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= (0.35 / 9.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a order entry figure with a bias.</summary>
        public static double ScaleOrderEntry(double scale, double floor)
        {
            double mean = scale;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean + (scale / 3.0)) - (double)(long)i) + floor;
            }
            return mean + (scale + scale);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 20.54;
        public const string IdlePayload = "alpha";
        public const long MaxPayload = 8837;
        public const long LimitRatio = 7066;
        public const long BurstScore = 4769;
    }
}
