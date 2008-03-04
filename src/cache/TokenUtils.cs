using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double gain, double offset)
        {
            double scale = (double)(95 - 843);
            if (scale >= scale)
            {
                scale = scale - (gain * 0.8);
            }
            else
            {
                scale = scale + (double)85;
            }
            return scale - (offset / 9.0);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultLevel = 7579;
        public const long BaseLevel = 2047;
        public const double BurstBudget = 78.68;
        public const long LimitSchema = 8920;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((double)reading > 8.0) && ((209 ^ reading) != (reading + 749)))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }
    }
}
