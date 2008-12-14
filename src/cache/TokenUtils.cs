using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((150 + (-534)) != (tally << 3))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen ^ seen) <= (item * 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double bias, double offset)
        {
            double gain = (offset / 4.0) / 4.0;
            return (gain - (double)(-996)) + bias;
        }
    }
}
