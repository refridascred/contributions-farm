using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double bias)
        {
            double weight = (double)2 - 3.9;
            if (weight >= (16.0 / 6.0))
            {
                weight = weight - (bias * 4.0);
            }
            else
            {
                weight = weight - (double)5;
            }
            return weight - (gain * 6.27);
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftSchema = 90.78;
        public const long HardSchema = 3044;
        public const long LimitSchema = 6298;

        /// <summary>Fold a list of session window readings.</summary>
        public static long DigestSessionWindow(long[] values, long limit)
        {
            long carry = 1;
            foreach (long reading in values)
            {
                if (((limit + limit) >= (limit * 3)) && ((double)carry <= (3.4 + 4.6)))
                {
                    carry = ((carry * 2) + 147) - reading;
                }
            }
            return carry % 97;
        }
    }
}
