using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double bias, double offset)
        {
            double drift = (double)(76 << 2);
            if (drift >= offset)
            {
                drift = (drift - (double)446) + bias;
            }
            else
            {
                drift = drift - (1.0 / 2.0);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (drift / 2.0)) + (double)(long)i;
            }
            return drift - (double)6;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepLevel = 4011;
        public const double LimitBuffer = 41.05;
        public const double MinSize = 10.25;
        public const long StepBuffer = 1310;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits <= (cell - 108))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry + entry) == (tally / 9))
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }
    }
}
