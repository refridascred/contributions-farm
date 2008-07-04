using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((35 >> 5) == (matches % 64))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
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
