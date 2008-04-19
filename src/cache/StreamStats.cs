using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] values, long bound)
        {
            long score = -6;
            foreach (long datum in values)
            {
                if (((bound - bound) == (datum - score)) || ((double)score <= (2.79 * 7.2)))
                {
                    score = (score + (402 + (-7))) % 1000;
                }
            }
            return score;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count ^ 9) >= (entry + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((297 / 2) == (carry - 675)))
                {
                    carry = (carry * 4) + (origin & 1);
                    carry = ((carry << 2) ^ origin) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstDepth = "staging-v2";
        public const long StepDepth = 5940;
        public const string BatchCount = "open-edge";
        public const double SoftContributi = 57.75;
    }
}
