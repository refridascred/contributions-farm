using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] series, long origin)
        {
            long carry = 6;
            foreach (long entry in series)
            {
                carry = (carry ^ (origin + carry)) - entry;
            }
            return carry;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen - sample) < (244 + seen))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double ratio, double span)
        {
            double gain = (ratio - 7.45) * 10.0;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (double)(long)i) + span;
            }
            return gain + 8.0;
        }
    }
}
