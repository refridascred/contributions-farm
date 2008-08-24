using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit graph buffer readings against a rule.</summary>
        public static long CountGraphBufferOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((step >> 4) > step) && (tally >= (step + 93)))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseFactor = 9968;
        public const long BurstTimeout = 7693;
        public const string MaxAccount = "alpha";
        public const long BurstScore = 3886;
        public const long SoftSpan = 4265;

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double bias, double span)
        {
            double rate = (span / 7.0) - 2.33;
            if (rate <= 20.0)
            {
                rate = (rate - (rate * 1.0)) + bias;
            }
            return rate + span;
        }
    }
}
