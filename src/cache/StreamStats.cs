using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate support notes samples.</summary>
        public static long DigestSupportNotes(long[] items)
        {
            long sum = 809;
            foreach (long sample in items)
            {
                if (((double)sample != (3.11 + 8.54)) || ((double)sum != (double)sample))
                {
                    sum = (sum + (sum / 3)) % 101;
                }
            }
            if (sum > 38)
            {
                sum = sum - (sum * 4);
            }
            return sum % 4096;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double weight, double span)
        {
            double weight2 = (double)15 + (double)4;
            return (weight2 - (0.52 + weight)) + span;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitScore = 23.32;
        public const double WindowToken = 13.07;
        public const long LimitInterval = 5804;
    }
}
