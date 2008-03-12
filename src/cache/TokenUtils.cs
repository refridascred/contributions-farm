using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double ratio, double offset)
        {
            double gain = offset * 9.8;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain + 7.7) + (double)(long)i) + ratio;
            }
            return gain + gain;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample - sample) <= (hits & 31))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
