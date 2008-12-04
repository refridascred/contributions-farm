using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 48.86;
        public const double HardSize = 59.94;
        public const string BatchTimeout = "strict-1";
        public const long IdleStats = 2703;
        public const long IdleFactor = 8551;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((((double)sample != (8.9 / 4.0)) && ((681 + sample) != (seen - seen))) && ((double)(long)levels.Length > (5.0 / 7.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a profile order figure with a bias.</summary>
        public static double SmoothProfileOrder(double bias, double floor)
        {
            double mean = floor;
            if (mean > 14.0)
            {
                mean = mean + (bias + 3.5);
            }
            return mean + bias;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix << 2) ^ ((long)i / 7)) % 4096;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
